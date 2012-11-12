using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CoViVoClient
{
    class BasicClient
    {
        private const int STANDARD_PORT = 9050;

        private IPEndPoint ipEndPoint;
        private Socket serverSocket;

        /// <summary>
        ///     BasicClient constructor. As default sets the port to STANDARD_PORT
        /// </summary>
        BasicClient() : this(STANDARD_PORT){
        }

        /// <summary>
        ///     BasicClient constructor.
        /// </summary>
        /// <param name="port">Port with witch it will communicate.</param>
        BasicClient(int port) {
            ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }

        /// <summary>
        ///     Sends data to server.
        /// </summary>
        /// <param name="array">byte[] to send.</param>
        private void send(byte[] array) {
            send(array, ipEndPoint);
        }

        private void send(byte[] array, EndPoint endPoint) {
            serverSocket.SendTo(array, endPoint);
        }

        private int receive(byte[] array, ref EndPoint endPoint) {
            return serverSocket.ReceiveFrom(array, ref endPoint);
        }

        private void close() {
            serverSocket.Close();
        }

        static void Main(string[] args)
        {
            byte[] data = new byte[1024];

            BasicClient basicClient = new BasicClient();

            string welcome = "Hello, are you there?";
            data = Encoding.ASCII.GetBytes(welcome);
            basicClient.send(data);

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint tmpRemote = (EndPoint)sender;

            data = new byte[1024];
            int recv = basicClient.receive(data, ref tmpRemote);

            Console.WriteLine("Message received from {0}:", tmpRemote.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));

            basicClient.send(Encoding.ASCII.GetBytes("message 1"), tmpRemote);
            basicClient.send(Encoding.ASCII.GetBytes("message 2"), tmpRemote);
            basicClient.send(Encoding.ASCII.GetBytes("message 3"), tmpRemote);
            basicClient.send(Encoding.ASCII.GetBytes("message 4"), tmpRemote);
            basicClient.send(Encoding.ASCII.GetBytes("message 5"), tmpRemote);

            Console.WriteLine("Stopping client");
            basicClient.close();
        }
    }
}
