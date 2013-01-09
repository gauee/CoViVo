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
        private IPAddress addr = IPAddress.Any;
        private int port;
        protected TcpListener tcpListener;

        protected AbstractServer() : this(STANDARD_PORT){
        }

        protected AbstractServer(int port) {
            this.port = port;
            this.tcpListener = new TcpListener(addr, port);
        }

        public void runServer() {
            this.tcpListener.Start();
            while (true)
            {
                this.tcpListener.BeginAcceptTcpClient(handleClient, null);
            }
        }

        public abstract void handleClient(IAsyncResult result);
    }
}
