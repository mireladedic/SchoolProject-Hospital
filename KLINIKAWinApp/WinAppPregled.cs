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
    public partial class WinAppPregled : Form
    {
        public WinAppPregled()
        {
            InitializeComponent();
        }

        private void pregledGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void hitanGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PonistiButton_Click(object sender, EventArgs e)
        {

        }

        private void WinAppPregled_Load(object sender, EventArgs e)
        {

        }

        private void dodajPregledButton_Click(object sender, EventArgs e)
        {
            TrenutniState.odabraniPacijent.DajKarton().DodajPregled(new Pregled(hitanCB.Text == "da" ? true : false, zabiljeskeBox.Text, dateTimePicker1.Value, prvaPomocCB.Text == "da" ? true : false, rezultatCB.Text == "Zivot" ? RezultatPregleda.zivot : RezultatPregleda.smrt, uzrokSmrtiBox.Text, dateTimePicker2.Value, obdukcijaComboBox.Text == "da" ? true : false, dateTimePicker3.Value));
            Close();
        }
    }
}
