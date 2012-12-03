using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CoViVoServer
{
    public class BasicServer : AbstractServer
    {

        public override void runServer()
        {
            int recv;
            byte[] data = new byte[1024];

            Console.WriteLine("Waiting for a client...");

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint tmpRemote = (EndPoint)(sender);

            recv = receive(data, ref tmpRemote);

            Console.WriteLine("Message received from {0}:", tmpRemote.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));

            string welcome = "Welcome to my test server";
            data = Encoding.ASCII.GetBytes(welcome);
            sendTo(data, tmpRemote);

            for (int i = 0; i < 5; i++)
            {
                data = new byte[1024];
                recv = receive(data, ref tmpRemote);
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
            }
            close();
        }
    }
}
