using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViidesHarjoitus
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void lukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(lukuTB.Text == "-999")
                {
                    vastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach(var jasen in taulukko)
                    {
                        vastausLB.Text += jasen + " ";
                    }
                    vastausLB.Visible = true;
                    
                }
                else
                {
                    jono.Add(Int32.Parse(lukuTB.Text));
                    lukuTB.Text = "";
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            lukuTB.Text = "";
        }
    }
}
