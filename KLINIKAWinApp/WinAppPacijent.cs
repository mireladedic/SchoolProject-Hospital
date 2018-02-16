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
    public partial class WinAppPacijent : Form
    {
        public WinAppPacijent()
        {
            InitializeComponent();
        }
        public event EventHandler sacuvaoEvent;
        private Pacijent selektovan = null;
        private List<string> pretragaPacijenata;
        private DateTime vrijemeSlike;
        private Image slika;

        protected virtual void sacuvaoEventPozvan(EventArgs e)
        {

            var handler = sacuvaoEvent;
            if (handler != null)
                handler(this, e);
        }

        public void OcistiFormu()
        {
            imeBox.Text = "";
            prezimeBox.Text = "";
            jbmgMaskedTextBox.Text = "";
            adresaBox.Text = "";
            selektovan = null;

            pretraziListBox.ClearSelected();
        }
        private void Izaberi(Pacijent u)
        {
            if (u == null)
                return;
            imeBox.Text = u.info().Ime;
            prezimeBox.Text = u.info().Prezime;
            jbmgMaskedTextBox.Text = u.info().MaticniBroj.ToString();
            adresaBox.Text = u.info().Adresa;
            SpolComboBox.Text = u.info().Spol.ToString();
            bracnoStanjeCB.Text = u.info().BracnoStanje;
            dateTimePicker1.Value = u.info().DatumRodjenja;
            dateTimePicker2.Value = u.DatumPrijema;


            pretragaPacijenata = TrenutniState.pacijenti.Select(uu => uu.info().Ime + " " + uu.info().Prezime + "," + uu.info().MaticniBroj.ToString()).ToList();
            
        }

        private void pretraziListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pretraziListBox.SelectedItem == null) return;
            selektovan = TrenutniState.pacijenti.Find(u => u.info().MaticniBroj.ToString() == (pretraziListBox.SelectedItem.ToString().Split(',')[1]));
            if (selektovan == null)
                return;
            Izaberi(selektovan);
        }


        private void ucitajPacijentabutton_Click(object sender, EventArgs e)
        {
            if (selektovan == null)
            {
                Pacijent p = new Pacijent(imeBox.Text, prezimeBox.Text, dateTimePicker1.Value, long.Parse(jbmgMaskedTextBox.Text), char.Parse(SpolComboBox.Text), adresaBox.Text, bracnoStanjeCB.Text);
                p.Slika = slika;
                p.DatumPrijema = dateTimePicker1.Value;
                TrenutniState.DodajPacijenta(p);
                OcistiFormu();
                pretraziListBox.ClearSelected();
                pretragaPacijenata = TrenutniState.pacijenti.Select(u => u.info().Ime + " " + u.info().Prezime + "," + u.info().MaticniBroj.ToString()).ToList();
                pretraziListBox.DataSource = pretragaPacijenata;
                sacuvaoEventPozvan(e);
                return;
            }
            selektovan.info().Ime = imeBox.Text;
            selektovan.info().Prezime = prezimeBox.Text;
            selektovan.info().MaticniBroj = long.Parse(jbmgMaskedTextBox.Text);
            selektovan.info().Adresa = adresaBox.Text;
            selektovan.info().Spol = char.Parse(SpolComboBox.Text);
            selektovan.info().BracnoStanje = bracnoStanjeCB.Text;
            selektovan.info().DatumRodjenja = dateTimePicker1.Value;
            selektovan.DatumPrijema = dateTimePicker1.Value;
            selektovan.Slika = slika;
            OcistiFormu();
            pretraziListBox.ClearSelected();
            sacuvaoEventPozvan(e);
            pretragaPacijenata = TrenutniState.pacijenti.Select(u => u.info().Ime + " " + u.info().Prezime + "," + u.info().MaticniBroj.ToString()).ToList();
            pretraziListBox.DataSource = pretragaPacijenata;
        }

        private void knjizicaButton_Click(object sender, EventArgs e)
        {
            if(selektovan == null)
            {
                MessageBox.Show("Niste odabrali pacijenta");
                return;
            }
            TrenutniState.odabraniPacijent = selektovan;
            new WinAppKnjizica().Show();
        }

        private void kartonButton_Click(object sender, EventArgs e)
        {
            if (selektovan == null)
            {
                MessageBox.Show("Niste odabrali pacijenta");
                return;
            }
            TrenutniState.odabraniPacijent = selektovan;
            new WinAppKarton().Show();
        }

        private void ordinacijaButton_Click(object sender, EventArgs e)
        {
            if (selektovan == null)
            {
                MessageBox.Show("Niste odabrali pacijenta");
                return;
            }
            TrenutniState.odabraniPacijent = selektovan;
            new WinAppOrdinacija().Show();
        }

        private void racuniButton_Click(object sender, EventArgs e)
        {
            if (selektovan == null)
            {
                MessageBox.Show("Niste odabrali pacijenta");
                return;
            }
            TrenutniState.odabraniPacijent = selektovan;
            new WinAppRacun().Show();
        }

        private void WinAppPacijent_Load(object sender, EventArgs e)
        {
            pretragaPacijenata = TrenutniState.pacijenti.Select(u => u.info().Ime + " " + u.info().Prezime + "," +u.info().MaticniBroj.ToString()).ToList();
            pretraziListBox.DataSource = pretragaPacijenata;
        }
        private void unioSliku(object sender, SlikaArgumenti e)
        {
            vrijemeSlike = e.vrijeme;
            if (selektovan != null)
            {
                selektovan.Slika = e.img;
            }
            else
            {
                slika = e.img;
            }

        }


        private void unosSlike1_Load(object sender, EventArgs e)
        {
            unosSlike1.SacuvaoEvent += unioSliku;
        }

        private void maticniBrojPretragaBox_TextChanged(object sender, EventArgs e)
        {
            pretragaPacijenata = TrenutniState.pacijenti.FindAll(u => (u.info().Ime + " " + u.info().Prezime + " " + u.info().MaticniBroj.ToString()).Contains(maticniBrojPretragaBox.Text)).Select(u => u.info().Ime + " " + u.info().Prezime + "," + u.info().MaticniBroj.ToString()).ToList();
            pretraziListBox.DataSource = pretragaPacijenata;
            
        }
        

        private void brisiButton_Click(object sender, EventArgs e)
        {
            TrenutniState.pacijenti.RemoveAll(u => u.info().MaticniBroj == selektovan.info().MaticniBroj);
            OcistiFormu();
            sacuvaoEventPozvan(e);
            pretragaPacijenata = TrenutniState.pacijenti.Select(u => u.info().Ime + " " + u.info().Prezime + "," + u.info().MaticniBroj.ToString()).ToList();
            pretraziListBox.DataSource = pretragaPacijenata;
        }

        private void noviPacijentBtn_Click(object sender, EventArgs e)
        {
            OcistiFormu();
            pretraziListBox.ClearSelected();
        }

        private void SpolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
