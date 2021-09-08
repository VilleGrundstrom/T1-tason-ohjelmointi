using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paivakirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = System.IO.File.ReadAllText(@"C:\\Users\\Vilds\\source\\repos\\T1-tason-ohjelmointi\\Paivakirja\\demo.txt");
            teksti += syottoTB.Text;
            teksti += "" + DateTime.Now.ToString(" dd.MM.yyyy hh:mm") + "\n";
            TextWriter txt = new StreamWriter("C:\\Users\\Vilds\\source\\repos\\T1-tason-ohjelmointi\\Paivakirja\\demo.txt");
            txt.Write(teksti);
            txt.Close();
            Application.Exit();
        }
    }
}
