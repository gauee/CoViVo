using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CoViVo : Form
    {
        public CoViVo()
        {
            InitializeComponent();
        }

        private void form_load(object sender, EventArgs e)
        {
            // załadowanie całej formy
        }

        private void button_send(object sender, EventArgs e)
        {
            // obsługa przycisku "Wyślij" potwierdzającego wysłanie wiadomości do użytkownika
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Options_Click(object sender, EventArgs e)
        {
            // wybranie pola opcji (connect, disconnect)
        }

        private void disconnectTool_Click(object sender, EventArgs e)
        {
            // opcja disconnect, przerwanie połączenia z serwerem
        }

        private void connectTool_Click(object sender, EventArgs e)
        {
            //opcja connect, nawiązanie połączenia z serwerem
        }


        private void Status_Click(object sender, EventArgs e)
        {
            //wybranie pola "Status", zmiana statusu (available, unavailable...)
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            // wybranie pola ustawień "Settings"
        }

        private void logout_Click(object sender, EventArgs e)
        {
            //wylogowanie uzytkownika
        }

        private void Conv_box(object sender, EventArgs e)
        {
            //okno rozmowy
        }

        private void Your_box(object sender, EventArgs e)
        {
            //pole tekstowe do wprowadzania wiadomosci
        }

        private void BeBack_Click(object sender, EventArgs e)
        {
            //status zaraz wracam
        }

        private void Disturb_Click(object sender, EventArgs e)
        {
            // status nie przeszkadzac
        }

        private void Unavailable_Click(object sender, EventArgs e)
        {
            // status niedostępny
        }

        private void Available_Click(object sender, EventArgs e)
        {
            // status dostępny
        }

        private void Voice_CheckedChanged(object sender, EventArgs e)
        {
            // zaznaczenie 'ptaszka' przy Voice, włączenia opcji transmisji głosowej
        }

        private void Video_CheckedChanged(object sender, EventArgs e)
        {
            // zaznaczenie 'ptaszka' przy Video, włączenie opcji transmisji video
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            // aktualny status użytkownika
        }

        private void menu_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //całe menu dolne
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }










    }
}
