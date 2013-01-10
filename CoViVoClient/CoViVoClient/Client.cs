using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CoViVoClient
{
    class Client {
        private const int server_port = 9050;
        private const string server = "localhost";
        private TcpClient tcp_client;
        private NetworkStream tcp_stream;


        public Client() {
        }

        public bool connect() {
            try {
                this.tcp_client = new TcpClient(server, server_port);
                this.tcp_stream = this.tcp_client.GetStream();
            }
            catch (Exception e) {
                return false;
            }
            return true;
        }

        public bool send_message(byte[] msg) {
            try {
                tcp_stream.Write(msg, 0, msg.Length);
            }
            catch (Exception e) {
                return false;
            }
            return true;
        }

    }
}
