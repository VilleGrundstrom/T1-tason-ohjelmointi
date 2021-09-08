using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KahdestoistaHarjoitus
{
    public partial class kysymysta : Form
    {
        string[] oikeatVastaukset = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[] vastaukset = new string[10];
        int laskuri = 0;
        int oikein = 0;
        public kysymysta()
        {
            InitializeComponent();
            ARB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            BRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            CRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            DRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                laskuri++;
                KysymysLB.Text = "Vastaus " + (laskuri) + ". kysymykseen";
            }
            else
            {
                vastausLB.Text = "";
                ARB.Enabled = false;
                BRB.Enabled = false;
                CRB.Enabled = false;
                DRB.Enabled = false;
                for(int j = 0; j < 10; j++)
                {
                    if(vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                vastausLB.Text = "oikeita vastauksia oli: " + oikein;
                vastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
            {
            if (ARB.Checked == true)
            {
                ARB.Checked = false;
                laskuri--;
            }
            if (BRB.Checked == true)
            {
                BRB.Checked = false;
                laskuri--;
            }
            if (CRB.Checked == true)
            {
                CRB.Checked = false;
                laskuri--;
            }
            if (DRB.Checked == true)
            {
                DRB.Checked = false;
                laskuri--;
            }
        }

        private void kysymysta_Load(object sender, EventArgs e)
        {

        }
    }
}
