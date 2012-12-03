using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace CoViVoServer
{
    public class AppServer : AbstractServer {

        Dictionary<EndPoint, ChannelHandler> channels;
        int counter;
        public AppServer() {
            counter = 0;
            channels = new Dictionary<EndPoint, ChannelHandler>();
        }

        public override void runServer() {
            while (true) {
                int recv;
                byte[] data = new byte[1024];

                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
                EndPoint tmpRemote = (EndPoint)(sender);

                try
                {
                    recv = receive(data, ref tmpRemote);
                }
                catch (SystemException se) {
                    Console.WriteLine(" exception jakis");
                }
                Console.WriteLine("received : " + data.ToString());
                Console.WriteLine("  tmpRemote : " + tmpRemote.ToString());
                ChannelHandler channel;
                if (channels.ContainsKey(tmpRemote))
                {
                    channel = channels[tmpRemote];
                    channel.increment();
                }
                else
                {
                    channel = new ChannelHandler(this, tmpRemote);
                    channels.Add(tmpRemote, channel);
                    ThreadPool.QueueUserWorkItem(channel.runChannel, counter++);
                }
            }
        }

        class ChannelHandler
        {
            AbstractServer abstractServer;
            EndPoint endPoint;
            int id;

            public ChannelHandler(AbstractServer abstractServer, EndPoint endPoint)
            {
                this.abstractServer = abstractServer;
                this.endPoint = endPoint;
                this.id = 0;
            }

            public void increment() {
                ++this.id;
            }

            public void runChannel(Object threadNumber)
            {
                while (true)
                {
                    string welcome = "Welcome, u are thread: " + threadNumber + ", with id: " + id;
                    byte[] data = Encoding.ASCII.GetBytes(welcome);
                    Console.WriteLine("sending  : " + welcome);
                    try
                    {
                        abstractServer.sendTo(data, endPoint);
                        System.Threading.Thread.Sleep(2000);
                    } catch (SystemException se) {
                        Console.WriteLine("User threw exception : " + endPoint);
                    }
                }
            }
        }
    }
}
