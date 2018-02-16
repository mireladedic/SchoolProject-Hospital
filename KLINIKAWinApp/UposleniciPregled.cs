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
    public partial class UposleniciPregled : Form
    {
        public UposleniciPregled()
        {
            InitializeComponent();
        }
        private Brush[] SliceBrushes =
        {
            Brushes.Red,
            Brushes.LightGreen,
            Brushes.Blue,
            Brushes.LightBlue,
            Brushes.Green,
            Brushes.Lime,
            Brushes.Orange,
            Brushes.Fuchsia,
            Brushes.Yellow,
            Brushes.Cyan,
        };
        private Pen[] SlicePens = { Pens.Black };
        private float[] Values = new float[4];
        private void UposleniciPregled_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            for (int i = 0; i < 4; i++)
            {
                listView1.Columns.Add(Enum.GetName(typeof(Uloga), (Uloga)(i)), 100);
            }

            string[] data = new string[4];
            for (int i = 0; i < 4; i++)
            {
                Values[i] = TrenutniState.uposlenici.FindAll(u => u.Uloga == (Uloga)(i)).Count;

                data[i] = Values[i].ToString();
                
            }
            listView1.Items.Add(new ListViewItem(data));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            
        }
        private static void DrawPieChart(Graphics gr, Rectangle rect, Brush[] brushes, Pen[] pens, float[] values)
            {
                // Get the total of all angles.
                float total = values.Sum();

                // Draw the slices.
                float start_angle = 0;
                for (int i = 0; i < values.Length; i++)
                {
                    float sweep_angle = values[i] * 360f / total;
                    gr.FillPie(brushes[i % brushes.Length],
                        rect, start_angle, sweep_angle);
                    gr.DrawPie(pens[i % pens.Length],
                        rect, start_angle, sweep_angle);
                    start_angle += sweep_angle;
                }
            }

        private void UposleniciPregled_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            DrawPieChart(e.Graphics, new Rectangle(40, 40, 200, 200), SliceBrushes, SlicePens, Values);
        }
    }
}
