using System;
using Ssl;
using Ssl.Packet;
using System.Net;
using System.Diagnostics;

namespace SSL_Client_Test_Console
{
    internal class Program
    {
        private static SslClient _client;

        private static void Main()
        {
            Console.Title = "SSL Client Test";

            Start:

            Console.Write("Enter the IP address: ");
            var ip = Console.ReadLine();

            Console.Write("Enter the Port No. :");
            var port = Console.ReadLine();

            IPAddress serverIp;
            int serverPort;

            if (IPAddress.TryParse(ip ?? "", out serverIp) && int.TryParse(port, out serverPort))
            {
                _client = new SslClient(serverIp, serverPort);
                _client.SslClientStateChanged += _client_SslClientStateChanged;
                _client.SslErrorOccured += _client_SslErrorOccured;
                _client.SslPacketReceived += _client_SslPacketReceived;
                _client.Start();

            }
            else
            {
                Console.Clear();
                goto Start;
            }

            while (Console.ReadKey().Key!=ConsoleKey.Escape)
            {  
            }

            _client.Stop();
            Console.ReadLine();
            goto Start;
        }
        
        private static void _client_SslPacketReceived(SslClient client, SSL_WrapperPacket packet)
        {
            if(packet!=null && packet.detection!=null)
                if(packet.detection.balls!=null && packet.detection.balls.Count>0)
                    Console.WriteLine("New packet received. {0}",packet.detection.balls[0].x);
        }

        private static void _client_SslErrorOccured(SslClient client, Exception exception)
        {
            Console.WriteLine("Error: {0}",exception.Message);
        }

        private static void _client_SslClientStateChanged(SslClient client, bool receiving)
        {
            Console.WriteLine("Server Running: {0}",receiving);
        }
    }
}
