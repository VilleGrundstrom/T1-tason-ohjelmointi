using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuosikkiNimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tarkistaBT_Click(object sender, EventArgs e)
        {
            vastausLB.Text = "";
            vastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\Vilds\\source\repos\\T1-tason-ohjelmointi\\SuosikkiNimi\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Users\\Vilds\\source\\repos\\T1-tason-ohjelmointi\\SuosikkiNimi\\tytot.txt");
            string nimi = nimiTB.Text;
            int laskurip = 1, laskurit = 1;
            foreach (string poika in pojat)
            {
                if (nimi == poika)
                {
                    vastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi vuonna 2020";
                    vastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    vastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi vuonna 2020";
                    vastausLB.Visible = true;
                }
                laskurit++;
            }
            if (vastausLB.Visible == false)
            {
                vastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta!:(";
                vastausLB.Visible = true;
            }
        }
    }
}
