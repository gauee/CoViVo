using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using log4net;
using WrapperLib;

namespace CoViVoServer
{
    public class AppServer : AbstractServer {

        private static readonly ILog log = LogManager.GetLogger(typeof(AppServer));
        Queue<int> emptyPorts;

        public AppServer() : base() {
            emptyPorts = new Queue<int>();
            for (int i = 1; i <= 100; ++i) {
                emptyPorts.Enqueue(i);
            }
        }

        public override void handleClient(TcpClient tcpClient)
        {
            byte[] array = new byte[1024];
            Message msg = Util.Unwrap(array);
            if (msg is JoinServer) { 
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
            while (true) {
                // odczytanie komunikatu
            }
        }
    }
}
