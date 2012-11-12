using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CoViVoServer
{
    class BasicServer
    {
        private static const int STANDARD_PORT = 9050;

        private IPEndPoint ipEndPoint;
        private Socket socket;

        /// <summary>
        ///     Creates standard UDP Server.
        /// As default sets port to STANDART_PORT
        /// </summary>
        BasicServer() : this(STANDARD_PORT){
        }

        /// <summary>
        ///     Creates standard UDP Server.
        /// </summary>
        /// <param name="port">Port number that the server will bind to.</param>
        BasicServer(int port) {
            ipEndPoint = new IPEndPoint(IPAddress.Any, 9050);
            socket = new Socket(AddressFamily.InterNetwork,
                            SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(ipEndPoint);
        }

        private int receive(byte[] data, ref EndPoint endPoint) {
            return socket.ReceiveFrom(data, ref endPoint);
        }

        private void sendTo(byte[] array, EndPoint endPoint) {
            socket.SendTo(array, endPoint);
        }

        private void close() {
            socket.Close();
        }

        static void Main(string[] args)
        {
            BasicServer basicServer = new BasicServer();
            int recv;
            byte[] data = new byte[1024];

            Console.WriteLine("Waiting for a client...");

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint tmpRemote = (EndPoint)(sender);

            recv = basicServer.receive(data, ref tmpRemote);

            Console.WriteLine("Message received from {0}:", tmpRemote.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));

            string welcome = "Welcome to my test server";
            data = Encoding.ASCII.GetBytes(welcome);
            basicServer.sendTo(data, tmpRemote);

            for (int i = 0; i < 5; i++)
            {
                data = new byte[1024];
                recv = basicServer.receive(data, ref tmpRemote);
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
            }
            basicServer.close();
        }
    }
}
