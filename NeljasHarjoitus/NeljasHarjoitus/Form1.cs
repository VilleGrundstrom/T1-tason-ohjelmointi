using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeljasHarjoitus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = ikaDTP.Value;
            DateTime nyt = DateTime.Now;
            Double erotus = Math.Round((nyt - synttari).TotalDays);
            vuosinaLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta";
            kuukausinaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            paivaLB.Text = (erotus + " päivää");
            tunteinaLB.Text = (erotus * 24 + " tuntia");
            minuutteinaLB.Text = (erotus * 24 * 60 + " minuuttia");
            sekuntteinaLB.Text = (erotus * 24 * 3600 + " sekuntia");
            vuosinaLB.Visible = true;
            kuukausinaLB.Visible = true;
            paivaLB.Visible = true;
            tunteinaLB.Visible = true;
            minuutteinaLB.Visible = true;
            sekuntteinaLB.Visible = true;
        }
    }
}
