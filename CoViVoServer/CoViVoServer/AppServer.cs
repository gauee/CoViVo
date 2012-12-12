using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using log4net;

namespace CoViVoServer
{
    public class AppServer : AbstractServer {

        private static readonly ILog log = LogManager.GetLogger(typeof(AppServer));
        Dictionary<EndPoint, ChannelHandler> channels;
        int counter;

        public AppServer() {
            counter = 0;
            channels = new Dictionary<EndPoint, ChannelHandler>();
        }

        void handleClient() {
            int recv;
            byte[] data = new byte[1024];
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint tmpRemote = (EndPoint)(sender);
            try{
                log.Info("Waiting for message");
                recv = receive(data, ref tmpRemote);
                log.Info("Received data from: " + tmpRemote.ToString() + " , message : " + data.ToString());
                ChannelHandler channel;
                if (channels.ContainsKey(tmpRemote))
                {
                    channel = channels[tmpRemote];
                }
                else
                {
                    channel = new ChannelHandler(this, tmpRemote);
                    channels.Add(tmpRemote, channel);
                    ThreadPool.QueueUserWorkItem(channel.runChannel, counter++);
                }
            } catch (SystemException se) {
                Console.WriteLine("Exception while communicating with client.");
            }
        }

        public override void runServer() {
            log.Info("Starting server");
            while (true) {
                handleClient();
            }
            log.Info("Stoping server");
        }

        class ChannelHandler
        {
            AbstractServer abstractServer;
            EndPoint endPoint;

            public ChannelHandler(AbstractServer abstractServer, EndPoint endPoint)
            {
                this.abstractServer = abstractServer;
                this.endPoint = endPoint;
            }

            public void runChannel(Object threadNumber)
            {
                while (true)
                {
                }
            }
        }
    }
}
