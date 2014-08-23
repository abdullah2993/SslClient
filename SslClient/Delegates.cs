using System;
using Ssl.Packet;

namespace Ssl
{
    public delegate void SslErrorOccuredEventHandler(SslClient client, Exception exception);

    public delegate void SslClientStateChangedEventHandler(SslClient client, bool receiving);

    public delegate void SslPacketReceivedEventHandler(SslClient client, SSL_WrapperPacket packet);

}
