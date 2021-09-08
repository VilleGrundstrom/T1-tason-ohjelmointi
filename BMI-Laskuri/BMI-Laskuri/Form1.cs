using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Laskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus), 2);
            if(bmi < 18.5)
            {
                vastausLB.Text = "Painoindeksisi on " + bmi;
                vastausLB.ForeColor = Color.Aqua;
                PainoLB.Text = "Alipaino";
                PainoLB.ForeColor = Color.Aqua;
                PainoLB.Visible = true;
            }
            else if(bmi < 25)
            {
                vastausLB.Text = "Painoindeksisi on " + bmi;
                vastausLB.ForeColor = Color.Green;
                PainoLB.Text = "Normaalipaino";
                PainoLB.ForeColor = Color.Green;
                PainoLB.Visible = true;
            }
            else if(bmi < 40)
            {
                vastausLB.Text = "Painoindeksisi on " + bmi;
                vastausLB.ForeColor = Color.Gold;
                PainoLB.Text = "Ylipaino";
                PainoLB.ForeColor = Color.Gold;
                PainoLB.Visible = true;
            }
            else
            {
                vastausLB.Text = "Painoindeksisi on " + bmi;
                vastausLB.ForeColor = Color.Red;
                PainoLB.Text = "Huomattava ylipaino";
                PainoLB.ForeColor = Color.Red;
                PainoLB.Visible = true;
            }
        }
    }
}
