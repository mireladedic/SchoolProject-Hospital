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
    public partial class WinAppUposlenik : Form
    {
        public WinAppUposlenik()
        {
            InitializeComponent();
        }
        private Uposlenik selektovan = null;
        private List<string> pretragaUposlenika;
        
        private void pretraziListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            selektovan = TrenutniState.uposlenici.Find(u => u.Username == (string)pretraziListBox.SelectedItem);
            Izaberi(selektovan);
        }
        public event EventHandler sacuvaoEvent;

        protected virtual void sacuvaoEventPozvan(EventArgs e)
        {
            
            var handler = sacuvaoEvent;
            if (handler != null)
                handler(this, e);
        }

        private void OcistiFormu()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            imeText.Text = "";
            prezimeText.Text = "";
            plataText.Text = "";
            nazivText.Text = "";
            BonusText.Text = "";
            selektovan = null;
            
            pretraziListBox.ClearSelected();
        }
        private void Izaberi(Uposlenik u)
        {
            if (u == null)
                return;
            usernameTextBox.Text = u.Username;
            passwordTextBox.Text = u.Password;
            imeText.Text = u.Ime;
            prezimeText.Text = u.Prezime;
            plataText.Text = u.Plata.ToString();
            nazivText.Text = u.Naziv;
            pictureBox1.Image = u.Slika;
            if (selektovan.Uloga == Uloga.Medicinski_Radnik)
            {
                BonusText.Text = ((MedicinskiRadnik)selektovan).Bonus.ToString();
            }
            else BonusText.Text = "";
            pretragaUposlenika = TrenutniState.uposlenici.Select(uu => uu.Username).ToList();
        }

        protected virtual void dodajUpButton_Click(object sender, EventArgs e)
        {
            if (vrsteUposlenikaBox.SelectedValue == null)
            {
                MessageBox.Show("Odaberite vrstu uposlenika.");
                return;
            }
            if(TrenutniState.uposlenici.Exists(u => u.Username.ToLower() == usernameTextBox.Text.ToLower()) && selektovan == null)
            {
                MessageBox.Show("Uposlenik sa ovim korisnickim imenom vec postoji.");
                return;
            }
            if(selektovan != null)
            {
                selektovan.Slika = pictureBox1.Image;
                selektovan.Ime = imeText.Text;
                selektovan.Prezime = prezimeText.Text;
                selektovan.Plata = double.Parse(plataText.Text);
                if (selektovan.Uloga == Uloga.Medicinski_Radnik)
                {
                    ((MedicinskiRadnik)selektovan).Bonus = double.Parse(BonusText.Text);
                }

                selektovan.Username = usernameTextBox.Text;
                selektovan.Password = passwordTextBox.Text;
                OcistiFormu();
                pretraziListBox.ClearSelected();
                return;
            }

            switch (vrsteUposlenikaBox.SelectedIndex)
            {
                case 0:
                    Uposlenik x = new MedicinskiRadnik(imeText.Text, prezimeText.Text, usernameTextBox.Text, passwordTextBox.Text, nazivText.Text, double.Parse(plataText.Text), double.Parse(BonusText.Text), pictureBox1.Image);
                    x.DajUlogu(Uloga.Medicinski_Radnik);
                    TrenutniState.DodajUposlenika(x);
                    break;
                case 1:
                    Uposlenik y = new NeMedicinskiRadnik(imeText.Text, prezimeText.Text, nazivText.Text, usernameTextBox.Text, passwordTextBox.Text, double.Parse(plataText.Text), pictureBox1.Image);
                    y.DajUlogu(Uloga.NeMedicinski_Radnik);
                    TrenutniState.DodajUposlenika(y);
                    break;
                case 2:
                    Uposlenik z = new VanjskiSaradnik(imeText.Text, prezimeText.Text, nazivText.Text, usernameTextBox.Text, passwordTextBox.Text, double.Parse(plataText.Text), pictureBox1.Image);
                    z.DajUlogu(Uloga.Vanjski_Saradnik);
                    TrenutniState.DodajUposlenika(z);
                    break;
                case 3:
                    Uposlenik u = new VanjskiSaradnik(imeText.Text, prezimeText.Text, nazivText.Text, usernameTextBox.Text, passwordTextBox.Text, double.Parse(plataText.Text), pictureBox1.Image);
                    u.DajUlogu(Uloga.Administrator);
                    TrenutniState.DodajUposlenika(u);
                    break;
            }
            //TrenutniState.DodajUposlenika()
            OcistiFormu();
            pretragaUposlenika = TrenutniState.uposlenici.Select(u => u.Username).ToList();
            pretraziListBox.DataSource = pretragaUposlenika;
            pretraziListBox.ClearSelected();
            sacuvaoEventPozvan(e);
        }
       
        private void ponistiUpButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajUpPicButton_Click(object sender, EventArgs e)
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

        private void brisiButton_Click(object sender, EventArgs e)
        {
            TrenutniState.uposlenici.RemoveAll(u => u.Username == selektovan.Username);
            OcistiFormu();
            sacuvaoEventPozvan(e);
        }

        private void WinAppUposlenik_Load(object sender, EventArgs e)
        {
            vrsteUposlenikaBox.DataSource = new List<string> { "Medicinski radnik", "NeMedicinski radnik", "Vanjski saradnik", "Administrator"};
            pretragaUposlenika = TrenutniState.uposlenici.Select(u => u.Username).ToList();
            pretraziListBox.DataSource = pretragaUposlenika;
        }

        private void ponistiUpPicButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void pretragaBox_TextChanged(object sender, EventArgs e)
        {
            pretragaUposlenika = TrenutniState.uposlenici.FindAll(u => u.Username.Contains(pretragaBox.Text)).Select(u => u.Username).ToList();
            pretraziListBox.DataSource = pretragaUposlenika;
        }

        

        private void noviUposlenikButton_Click(object sender, EventArgs e)
        {
            OcistiFormu();
            pretraziListBox.ClearSelected();
        }

        private void vrsteUposlenikaBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
