using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kahvila
{
    public partial class ruokalistaForm : Form
    {
        public ruokalistaForm()
        {
            InitializeComponent();
            meistaPL.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void koriPL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruokalistaForm_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            meistaLB.Text += "9:00 - 14:30 joka päivä maanantaisin, torstaisin ja perjantaisin \n";
            meistaLB.Text += "9:00 - 12.30. \n\n Keudan oppilaskunnan kahvilasta saa lämpimien \n";
            meistaLB.Text += "Juomien lisäksi virvokkeita sekä pientä purtavaa sekä makesia \n";
            meistaLB.Text += "Tervetuloa tutustumaan!";
            meistaLB.Font = new Font("Comic Sans MS", 12);

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void meistaBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = true;
            ruatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void RuoatBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruatPL.Visible = true;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruatPL.Visible = false;
            juomatPL.Visible = true;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void herkutBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = true;
            koriPL.Visible = false;
        }

        private void koriBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = true;
        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
