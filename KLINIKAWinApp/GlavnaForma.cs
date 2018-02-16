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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();

        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            uposleniciTreeView.BeginUpdate();
            string glavniNode = "Administratori";
            uposleniciTreeView.Nodes.Add(glavniNode);
            TreeNode parentNode = uposleniciTreeView.Nodes[0];
            if (parentNode != null)
            {
                parentNode.Nodes.Add(TrenutniState.prijavljeni.Ime + " " + TrenutniState.prijavljeni.Prezime);
                
            }

            uposleniciTreeView.EndUpdate();
            uposleniciTreeView.ExpandAll();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
