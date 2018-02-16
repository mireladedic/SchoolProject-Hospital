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
    public partial class WinAppGlavniMeni : Form
    {
        public WinAppGlavniMeni()
        {
            InitializeComponent();
        }


        private void WinAppGlavniMeni_Load(object sender, EventArgs e)
        {
            
            refreshUposleniciView(sender, e);

            Pacijent p = new Pacijent("Bill", "Gates", new DateTime(1945, 1, 13), 484818966, 'M', "Washington", "Ozenjen");
            p.DodajBolest(new Bolest("Starost", new DateTime(), "Star", VrstaBolovanja.Bolest));
            p.DodajKnjizicu(41484, new DateTime(1920, 12, 15), new DateTime(2050, 10, 12));
            p.DodajMisljenje("Nema ga");
            p.DatumPrijema = new DateTime(1920, 12, 15);
            p.DodajPregled(new Pregled(true, "Zab", new DateTime(), true, RezultatPregleda.zivot, "Nema", default(DateTime), false, default(DateTime)));
            p.DodajTerapiju(new Terapija(VrstaTerapije.dugorocna, true, new DateTime(), false));
            TrenutniState.DodajPacijenta(p);
            Pacijent x = new Pacijent("Jackie", "Chan", new DateTime(1950, 5, 5), 77875752, 'Z', "Hong Kong", "Ozenjen");
            x.DodajBolest(new Bolest("Starost", new DateTime(), "Star", VrstaBolovanja.Bolest));
            x.DodajBolest(new Bolest("Preglada", new DateTime(), "Prehlada", VrstaBolovanja.Bolest));
            x.DodajKnjizicu(48481, new DateTime(1920, 12, 15), new DateTime(2050, 10, 12));
            x.DodajMisljenje("Nema ga");
            x.DatumPrijema = new DateTime(1920, 12, 15);
            x.DodajPregled(new Pregled(true, "Zab", new DateTime(), true, RezultatPregleda.zivot, "Nema", default(DateTime), false, default(DateTime)));
            x.DodajTerapiju(new Terapija(VrstaTerapije.dugorocna, true, new DateTime(), false));
            TrenutniState.DodajPacijenta(x);

            Pacijent y = new Pacijent("Bruce", "Leee", new DateTime(1920, 12, 15), 12123545, 'M', "Shanghai", "Ozenjen");
            y.DodajBolest(new Bolest("Starost", new DateTime(), "Star", VrstaBolovanja.Bolest));
            y.DodajBolest(new Bolest("Preglada", new DateTime(), "Prehlada", VrstaBolovanja.Bolest));
            y.DodajKnjizicu(48481, new DateTime(1920, 12, 15), new DateTime(2050, 10, 12));
            y.DodajMisljenje("Nema ga");
            y.DatumPrijema = new DateTime(1920, 12, 15);
            y.DodajPregled(new Pregled(true, "Zab", new DateTime(), true, RezultatPregleda.zivot, "Nema", default(DateTime), false, default(DateTime)));
            y.DodajTerapiju(new Terapija(VrstaTerapije.dugorocna, true, new DateTime(), false));
            TrenutniState.DodajPacijenta(y);

            refreshPacijentiView(sender, e);
        }
        private void refreshPacijentiView(object sender, EventArgs e)
        {
            pacijentiTreeView.Nodes.Clear();
            pacijentiTreeView.BeginUpdate();

            pacijentiTreeView.Nodes.Add("Pacijenti");
            int ee = 0;
            foreach (var pacijent in TrenutniState.pacijenti.OrderBy(u => u.info().Ime))
            {
                TreeNode parentNode = pacijentiTreeView.Nodes[ee];

                parentNode.Nodes.Add(pacijent.info().Ime + " " + pacijent.info().Prezime);
            }
            pacijentiTreeView.EndUpdate();
            pacijentiTreeView.ExpandAll();
        }

        private void refreshUposleniciView(object sender, EventArgs e)
        {
            uposleniciTreeView.Nodes.Clear();
            uposleniciTreeView.BeginUpdate();
            Uloga? prva = null;
            int ee = 0;
            foreach (var uposlenik in TrenutniState.uposlenici.OrderBy(u => u.Uloga))
            {
                if (prva == null)
                {
                    prva = Uloga.Administrator;
                    uposleniciTreeView.Nodes.Add(Enum.GetName(typeof(Uloga), prva));
                    TreeNode parentNode = uposleniciTreeView.Nodes[ee];

                    parentNode.Nodes.Add(uposlenik.Ime + " " + uposlenik.Prezime);
                }
                else if (uposlenik.Uloga != prva)
                {
                    prva = (Uloga)(++ee);
                    uposleniciTreeView.Nodes.Add(Enum.GetName(typeof(Uloga), prva));
                    TreeNode parentNode = uposleniciTreeView.Nodes[ee];

                    parentNode.Nodes.Add(uposlenik.Ime + " " + uposlenik.Prezime);
                }
                else if (uposlenik.Uloga == prva)
                {
                    TreeNode parentNode = uposleniciTreeView.Nodes[ee];
                    parentNode.Nodes.Add(uposlenik.Ime + " " + uposlenik.Prezime);
                }
            }
            uposleniciTreeView.EndUpdate();
            uposleniciTreeView.ExpandAll();
        }

        private void dodaoNovogUposlenika(object sender, EventArgs e)
        {
            refreshUposleniciView(sender, e);
        }
        private void dodaoNovogPacijenta(object sender, EventArgs e)
        {
            refreshPacijentiView(sender, e);
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAppUposlenik WU = new WinAppUposlenik();
            WU.sacuvaoEvent += dodaoNovogUposlenika;
            WU.Show();
        }

        private void WinAppGlavniMeni_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UposleniciPregled().Show();
        }

        private void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void pretragaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            WinAppPacijent WU = new WinAppPacijent();
            WU.sacuvaoEvent += dodaoNovogPacijenta;
            WU.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WinAppOrdinacija().Show();
        }
    }
}
