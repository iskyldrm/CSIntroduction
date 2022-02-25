using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileForm
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void kişiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileForm KisiKayit = new FileForm();
            KisiKayit.MdiParent = this;
            KisiKayit.Show();

        }

        private void kişileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KisiListesi kisilistesi = new KisiListesi();
            kisilistesi.MdiParent = this;
            kisilistesi.Show();
        }
    }
}
