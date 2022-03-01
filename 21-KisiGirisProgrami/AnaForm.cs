using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_KisiGirisProgrami
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void kisiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KisiKayit kayitformu = new KisiKayit();
            kayitformu.MdiParent = this;
            kayitformu.Show();
            
        }

        private void kisileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KisiListesi kisiListesi = new KisiListesi();
            kisiListesi.MdiParent = this;
            kisiListesi.Show();
        }

        private void cinsiyeteGoreEgitimDagilimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CinsiyeteGoreEgitimDagilimiFormu dagilimiFormu = new CinsiyeteGoreEgitimDagilimiFormu();
            dagilimiFormu.MdiParent = this;
            dagilimiFormu.Show();
        }

        private void cinsiyeteGöreTakimDagilimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CinsiyetGoreTakimDagilimiFormu cinsiyetTakimFormu = new CinsiyetGoreTakimDagilimiFormu();
            cinsiyetTakimFormu.MdiParent = this;
            cinsiyetTakimFormu.Show();
        }
    }
}
