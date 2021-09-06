using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToinenHarjoitus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tulostaBT_Click(object sender, EventArgs e)
        {
            string teksti = tulostaTB.Text;
            vastausLB.Text = teksti;
            vastausLB.Visible = true;
        }
    }
}
