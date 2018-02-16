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
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "mirela" && passTextBox.Text == "mirela")
            {
                TrenutniState.prijavljeni = new MedicinskiRadnik("Mirela", "Dedic", "Admin", 0, 0);
                TrenutniState.prijavljeni.DajUlogu(Uloga.Administrator);
          
                new GlavnaForma().Show();
                Hide();
            }
        }

        private void buttonPonisti_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
