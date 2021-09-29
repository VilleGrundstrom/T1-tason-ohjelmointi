using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opiskelijanhallintajarjestelma
{
    public partial class opiskelijataulu : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();
        public opiskelijataulu()
        {
            InitializeComponent();
        }

        private void opiskelijataulu_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            etunimiTB.Text = "";
            sukunimiTB.Text = "";
            puhelinTB.Text = "";
            emailTB.Text = "";
            opiskelijanroTB.Text = "";
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String puhelin = puhelinTB.Text;
            String email = emailTB.Text;
            int oNro = Int32.Parse(opiskelijanroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void paivitaBT_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String puhelin = puhelinTB.Text;
            String email = emailTB.Text;
            int oNro = Int32.Parse(opiskelijanroTB.Text);
            int oid = Int32.Parse(idTB.Text);

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - ID, Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void TietotauluDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
            etunimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            sukunimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhelinTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            emailTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            opiskelijanroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = idTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }
    }
}
