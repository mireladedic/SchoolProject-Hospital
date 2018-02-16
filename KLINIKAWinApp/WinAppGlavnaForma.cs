using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLINIKAWinApp
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Dock = DockStyle.Fill;
            //pictureBox1.BackColor = Color.White;
            //pictureBox1.Paint += new PaintEventHandler(this.pictureBox1_Paint);
            
            //Controls.Add(pictureBox1);
        }
      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonPonisti_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                TrenutniState.prijavljeni = new MedicinskiRadnik("Mirela", "Dedic", "admin", "admin", "Admin", 0, 0, null);
                TrenutniState.prijavljeni.DajUlogu(Uloga.Administrator);
                TrenutniState.DodajUposlenika(TrenutniState.prijavljeni);
                new WinAppGlavniMeni().Show();
                Hide();
            }
            else
            {
                if(!TrenutniState.uposlenici.Exists(r => r.Username.ToLower() == usernameTextBox.Text.ToLower() && r.Password == passwordTextBox.Text)) {
                    MessageBox.Show("Pogresna sifra!");
                    return;
                }
                TrenutniState.prijavljeni = TrenutniState.uposlenici.Find(r => r.Username.ToLower() == usernameTextBox.Text.ToLower() && r.Password == passwordTextBox.Text);
                new WinAppGlavniMeni().Show();
                Hide();
             
            }
        }

        private void usernameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                e.Cancel = true;
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "Korisnicko ime ne smije biti prazno");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(usernameTextBox, "");
            }
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                e.Cancel = true;
                usernameTextBox.Focus();
                errorProvider1.SetError(passwordTextBox, "Sifra ne smije biti prazna");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(passwordTextBox, "");
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var fontFamily = new FontFamily("Arial");
            var font = new Font(fontFamily, 58, FontStyle.Bold, GraphicsUnit.Pixel);
            var solidBrush = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(255, 0, 120, 120));

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            
            e.Graphics.DrawString("KLINIKA", font, solidBrush, 300, 70);
            
        }
    }
}
