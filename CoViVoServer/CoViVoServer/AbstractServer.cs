using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CoViVoServer
{
    public abstract class AbstractServer
    {
        private const int STANDARD_PORT = 9050;

        private IPEndPoint ipEndPoint;
        private Socket socket;

        protected AbstractServer() : this(STANDARD_PORT){
        }

        protected AbstractServer(int port) {
            ipEndPoint = new IPEndPoint(IPAddress.Any, 9050);
            socket = new Socket(AddressFamily.InterNetwork,
                            SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(ipEndPoint);
        }

        public int receive(byte[] data, ref EndPoint endPoint) {
            return socket.ReceiveFrom(data, ref endPoint);
        }

        public void sendTo(byte[] array, EndPoint endPoint) {
            socket.SendTo(array, endPoint);
        }

        public void close() {
            socket.Close();
        }

        public abstract void runServer();
    }
}
