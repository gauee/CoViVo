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

        public override void handleClient(IAsyncResult result)
        {
            TcpClient tcpClient = this.tcpListener.EndAcceptTcpClient(result);
            int recv;
            byte[] data = new byte[1024];
            NetworkStream networkStream = tcpClient.GetStream();
            recv = networkStream.Read(data, 0, 1024);
            Console.WriteLine(" read : " + data);
            String message = "Hello to server";
            data = ASCIIEncoding.UTF8.GetBytes(message);
            networkStream.Write(data, 0, data.Length);
            tcpListener.BeginAcceptTcpClient(handleClient, null);
        }
    }
}
