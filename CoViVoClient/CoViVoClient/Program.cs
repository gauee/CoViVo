using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoViVoClient
{
    namespace WindowsFormsApplication1
    {
        static class Program
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Client client = new Client();
                byte[] msg1 = Encoding.ASCII.GetBytes("Pierwsza wiadomosc");
                byte[] msg2 = Encoding.ASCII.GetBytes("Druga wiadomosc");
                byte[] msg3 = Encoding.ASCII.GetBytes("Trzecia wiadomosc");

                if (client.connect()) {
                    Console.WriteLine("Polaczono z serwerem");
                }
                else {
                    Console.WriteLine("Blad przy polaczeniu");
                }
                if (client.send_message(msg1)) {
                    Console.WriteLine("Wyslano pierwsza wiadomosc");
                    while (true) { }
                }
                else {
                    Console.WriteLine("Nie udalo sie wyslac wiadomosci");
                }
                return;
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new CoViVo());
            }
        }
    }
}