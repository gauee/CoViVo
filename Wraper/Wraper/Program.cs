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
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

            avt.text = "kuba";

            byte[] b = Util.Wrap(avt);
            Console.WriteLine(encoding.GetString(b));
            Text at = (Text)Util.Unwrap(b);
            Console.WriteLine(at.messageCode);
            Console.WriteLine(at.messageNumber);
            Console.WriteLine(at.text);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
