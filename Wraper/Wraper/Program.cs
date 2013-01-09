using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrapperLib;

namespace Wraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Text avt;
            avt = new Text();
            avt.messageCode = 5;
            avt.messageNumber = 1000;

            avt.text = "kuba";

            byte[] b = Util.Wrap(avt);
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            Console.WriteLine(encoding.GetString(b));
            Message msg = Util.Unwrap(b);
            if (msg is Text)
            {
                Text at = (Text)msg;
                Console.WriteLine(at.messageCode);
                Console.WriteLine(at.messageNumber);
                Console.WriteLine(at.text);
                Console.WriteLine();
                Console.ReadKey();
            }
            else {
                Console.WriteLine("Nieudane typowanie obiektu.");
            }
        }
    }
}
