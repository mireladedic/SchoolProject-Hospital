using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLINIKAWinApp
{
    public partial class WinAppKarton : Form
    {
        public WinAppKarton()
        {
            InitializeComponent();
        }
        
        private void WinAppKarton_Load(object sender, EventArgs e)
        {
            imeBox.Text = TrenutniState.odabraniPacijent.info().Ime;
            prezimeBox.Text = TrenutniState.odabraniPacijent.info().Prezime;
            jmbgBox.Text = TrenutniState.odabraniPacijent.info().MaticniBroj.ToString();
            adresaBox.Text = TrenutniState.odabraniPacijent.info().Adresa;
            if (TrenutniState.odabraniPacijent.info().Spol == 'M')
            {
                muskoRadioButton.Enabled = true;
                zenskiRadioButton.Enabled = false;
            }
            if (TrenutniState.odabraniPacijent.info().Spol == 'Z')
            {
                muskoRadioButton.Enabled = false;
                zenskiRadioButton.Enabled = false;
            }
            if (TrenutniState.odabraniPacijent.info().BracnoStanje == "Ozenjen/Udata")
            {
                uBrakuRadioButton.Enabled = true;
                slobodanRadioButton.Enabled = false;
            }
            if (TrenutniState.odabraniPacijent.info().BracnoStanje == "Slobodan/Slobodna")
            {
                uBrakuRadioButton.Enabled = false;
                slobodanRadioButton.Enabled = true;
            }
            zakljucakBox.Text = TrenutniState.odabraniPacijent.DajKarton().ZakljucakDoktora;
            preglediBox.DataSource = TrenutniState.odabraniPacijent.DajKarton().Pregledi.Select(p => p.DatumPregleda.ToLocalTime().ToString()).ToList();
            terapijeBox.DataSource = TrenutniState.odabraniPacijent.DajKarton().Terapije.Select(p => p.DatumPropisivanja.ToLocalTime().ToString()).ToList();
            bolestiBox.DataSource = TrenutniState.odabraniPacijent.DajKarton().Bolesti.Select(p => p.VrijemeBolovanja.ToLocalTime().ToString() + " " + p.Naziv).ToList();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bracnoStanjeLabel_Click(object sender, EventArgs e)
        {

        }

        private void uBrakuRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dodajKartonButton_Click(object sender, EventArgs e)
        {
            TrenutniState.odabraniPacijent.info().Ime = imeBox.Text;
            TrenutniState.odabraniPacijent.info().Prezime = prezimeBox.Text;
            TrenutniState.odabraniPacijent.info().MaticniBroj = long.Parse(jmbgBox.Text);
            if (muskoRadioButton.Enabled) TrenutniState.odabraniPacijent.info().Spol = 'M';
            if (zenskiRadioButton.Enabled) TrenutniState.odabraniPacijent.info().Spol = 'Z';
            if (uBrakuRadioButton.Enabled) TrenutniState.odabraniPacijent.info().BracnoStanje = "Ozenjen/Udata";
            if (slobodanRadioButton.Enabled) TrenutniState.odabraniPacijent.info().BracnoStanje = "Slobodan/Slobodna";
            TrenutniState.odabraniPacijent.DajKarton().DodajZakljucak(zakljucakBox.Text);
            TrenutniState.odabraniPacijent.info().Adresa = adresaBox.Text;




        }

        private void dodajSlikuButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Odaberi sliku";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                }
            }
        }
    }
}
