using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CoViVoServer
{
    class TestProgram {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            // mozna testowac. podstawowa obsluga klienta. patrze basicServer.handleConnection
            AbstractServer basicServer = new BasicServer();
            basicServer.runServer();
            /*AbstractServer appServer = new AppServer();
            appServer.runServer();*/
        }
    }
}
