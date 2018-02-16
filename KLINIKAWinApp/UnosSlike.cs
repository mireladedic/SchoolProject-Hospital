using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLINIKAWinApp
{

    
    public partial class UnosSlike : UserControl
    {
        public UnosSlike()
        {
            InitializeComponent();
        }
        public event EventHandler<SlikaArgumenti> SacuvaoEvent;
        private void UnosSlike_Load(object sender, EventArgs e)
        {
            
        }
        protected virtual void sacuvaoEventPozvan(SlikaArgumenti e)
        {
            
            var handler = SacuvaoEvent;
            if (handler != null)
                handler(this, e);
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            sacuvaoEventPozvan(new SlikaArgumenti(null, new DateTime(2000, 1, 1)));
            pictureBox1.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Odaberi sliku";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                    sacuvaoEventPozvan(new SlikaArgumenti(pictureBox1.Image, dateTimePicker1.Value));
                }
            }
        }
    }
}
