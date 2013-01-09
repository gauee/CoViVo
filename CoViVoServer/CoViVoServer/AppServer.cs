using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using log4net;

namespace CoViVoServer
{
    public class AppServer : AbstractServer {

        private static readonly ILog log = LogManager.GetLogger(typeof(AppServer));
        Queue<int> emptyPorts;

        AppServer() : base() {
            emptyPorts = new Queue<int>();
            for (int i = 1; i <= 100; ++i) {
                emptyPorts.Enqueue(i);
            }
        }

        public override void handleClient(IAsyncResult result)
        {
            TcpClient tcpClient = this.tcpListener.EndAcceptTcpClient(result);
            // wczytaj obiekt informacji
            // jezeli jest to nowy kanal
            {
                int newPortNumber = emptyPorts.Dequeue();
                // send to the client information about the newPortNumber
                ChannelHandler channel = new ChannelHandler(newPortNumber);
                ThreadPool.QueueUserWorkItem(channel.runChannel, ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString());
            }
            { 

            }
        }

    }
    public class ChannelHandler {
        private int port;
        private String sourceIpAddress;
        private IPEndPoint ipEndPoint;
        private Socket socket;

        List<EndPoint> clients;

        public ChannelHandler(int portNumber) {
            this.port = portNumber;
            ipEndPoint = new IPEndPoint(IPAddress.Any, this.port);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(ipEndPoint);
        }

        public void runChannel(Object data) {
            sourceIpAddress = (String)data;
            while () {
                // odczytanie komunikatu
            }
        }
    }
}
