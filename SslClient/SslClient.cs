using System;
using ProtoBuf;
using System.IO;
using System.Net;
using Ssl.Packet;
using System.Net.Sockets;
using System.ComponentModel;
using System.Diagnostics;

namespace Ssl
{
    public sealed class SslClient:IDisposable
    {
        #region Private Members

        private volatile Socket _client;
        private SocketAsyncEventArgs _receivedArg;
        private readonly AsyncOperation _asyncOperation;

        #endregion

        #region Exposed Properties

        public IPEndPoint MulticastEndPoint { get; private set; }
        public bool Roboust { get; set; }
        public bool Listening { get; private set; }

        #endregion

        #region Evenvts

        public event SslClientStateChangedEventHandler SslClientStateChanged;
        public event SslPacketReceivedEventHandler SslPacketReceived;
        public event SslErrorOccuredEventHandler SslErrorOccured;

        #endregion

        #region Event Handlers

        private void OnSslClientStateChanged(bool receiving)
        {
            if(SslClientStateChanged!=null)
                SslClientStateChanged.Invoke(this,receiving);
        }

        private void OnSslPacketReceived(SSL_WrapperPacket packet)
        {
            if(SslPacketReceived!=null)
                SslPacketReceived.Invoke(this,packet);
        }

        private void OnSslErrorOccured(Exception exception)
        {
            if(SslErrorOccured!=null)
                SslErrorOccured.Invoke(this,exception);
        }

        #endregion

        #region Constructors

        public SslClient(IPEndPoint multicastEndPoint)
        {
            MulticastEndPoint = multicastEndPoint;
            _asyncOperation = AsyncOperationManager.CreateOperation(null);
            Roboust = true;
        }

        public SslClient(string multicastIp, int port):this(IPAddress.Parse(multicastIp),port)
        {          
        }

        public SslClient(IPAddress multicastIp, int port):this(new IPEndPoint(multicastIp,port))
        {         
        }

        #endregion

        #region Public Methods

        public void Start()
        {
            try
            {
                _receivedArg = new SocketAsyncEventArgs();
                _receivedArg.SetBuffer(new byte[10240], 0, 10240);
                _receivedArg.RemoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                _receivedArg.Completed += Process_Completed;

                _client = _client ?? new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                _client.Bind(new IPEndPoint(IPAddress.Any, MulticastEndPoint.Port));
                _client.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(MulticastEndPoint.Address, IPAddress.Any));

                if (!_client.ReceiveFromAsync(_receivedArg))
                    Process_Completed(null, _receivedArg);
                Listening = true;
                _asyncOperation.Post(receiving => OnSslClientStateChanged((bool)receiving), Listening);
            }
            catch (Exception exception)
            {
                _asyncOperation.Post(ex=>OnSslErrorOccured(ex as Exception),exception);
            }
        }

        public void Stop()
        {
            if(_client==null)
                return;

            try
            {
                Listening = false;
                _client.Shutdown(SocketShutdown.Both);
                _client.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.DropMembership, new MulticastOption(MulticastEndPoint.Address, IPAddress.Any));
                _client.Close();
                
                _asyncOperation.Post(receiving=>OnSslClientStateChanged((bool)receiving),Listening);
                if (_receivedArg != null)
                    _receivedArg.Dispose();
                _client = null;
                _receivedArg = null;
            }
            catch
            {
               Dispose();
            }
        }

        public void Dispose()
        {
            if (_client != null)
                _client.Close();
            if (_receivedArg != null)
                _receivedArg.Dispose();

            _client = null;
            _receivedArg = null;
        }

        #endregion

        #region Private Methods

        private void Process_Completed(object sender, SocketAsyncEventArgs e)
        {
            if (!Listening)
                return;

            if (e.SocketError == SocketError.Success)
            {
                if (e.LastOperation == SocketAsyncOperation.ReceiveFrom)
                {
                   using (var memoryStream = new MemoryStream(e.Buffer, 0, e.BytesTransferred))
                   {
                       try
                       {
                           var packet = Serializer.Deserialize<SSL_WrapperPacket>(memoryStream);
                           _asyncOperation.Post(pack => OnSslPacketReceived(pack as SSL_WrapperPacket), packet);
                       }
                       catch (Exception exception)
                       {
                           _asyncOperation.Post(ex => OnSslErrorOccured(ex as Exception), exception);
                       }

                       if(!_client.ReceiveFromAsync(e))
                           Process_Completed(null,e);
                   }
                }
            }
            else
            {
                _asyncOperation.Post(ex => OnSslErrorOccured(ex as Exception), new SocketException((int) e.SocketError));
                Stop();

                if (Roboust)
                    Start();
                
            }
        }

        #endregion 
    }
}