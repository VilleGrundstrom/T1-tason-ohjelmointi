using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eka_Harjoitus
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void vaihdaBT_Click(object sender, EventArgs e)
        {
            otsikkoLB.Text = "Heippa maailma";
        }
    }
}
