using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Util a= new Util();
            Console.WriteLine("Siema");
            Console.WriteLine(a.UnwrapTags(a.WrapWithTag("masdasd","asdasdasdas<asd>","</asd>adasdasdas"),"<asd>","</asd>"));

            ErrorWrapper err = new ErrorWrapper();
            ErrorWrapper err2 = new ErrorWrapper();
            
            err.SetError("asdasdas");
            Console.WriteLine(err.Wrap());

            err2.Unwrap(err.Wrap());
            Console.WriteLine(err2.Wrap());
            Console.WriteLine();

            MessageWrapper msg = new MessageWrapper();
            MessageWrapper msg2 = new MessageWrapper();

            msg.SetAudioMsg("asdasdas");
            msg.SetVideoMsg("adsadasaaa");

            Console.WriteLine(msg.Wrap());
            msg2.Unwrap(msg.Wrap());
            Console.WriteLine(msg2.Wrap());
            Console.WriteLine();
            CommunicationWrapper com = new CommunicationWrapper();
            CommunicationWrapper com2 = new CommunicationWrapper();

            com.SetAddChannel("asdasdas");
            com.SetChannelList("adsadasaaa");

            Console.WriteLine(com.Wrap());
            com2.Unwrap(com.Wrap());
            Console.WriteLine(com2.Wrap());
            Console.WriteLine();
            WrapperEngine eng = new WrapperEngine();
            WrapperEngine eng2 = new WrapperEngine();
            eng.errWrap = err;
            eng.msgWrap = msg;
            eng.comWrap = com;

            Console.WriteLine(eng.Wrap());
            eng2.Unwrap(eng.Wrap());
            Console.WriteLine(eng2.Wrap());
            Console.ReadKey();
        }
    }
}
