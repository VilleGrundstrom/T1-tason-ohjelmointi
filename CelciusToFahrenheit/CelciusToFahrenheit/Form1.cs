using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelciusToFahrenheit
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void muunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(asteetTB.Text);
            if(celciusRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                vastausLB.Text = asteet + " Fahrenheitia on " + vastaus + " Celcius astetta";
                vastausLB.Visible = true;
            }
            else if(fahreinheitRB.Checked)
            {
                vastaus = (asteet - 32) / 1.8;
                vastausLB.Text = asteet + " Celciusta on " + vastaus + " Fahrenheit astetta";
                vastausLB.Visible = true;
            }
            else
            {
                vastausLB.Text = "et valinnut muunnettavaa astetta tai antanut oikeaa lukua";
                vastausLB.Visible = true;
            }
        }
        
    }
}
