using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16.windowsformlab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
           string deger =  txtSayi.Text;

            int elmnsayisi = int.Parse(deger);
            List<int> sayilar = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < elmnsayisi; i++)
            {
                sayilar.Add(rnd.Next());
            }

            foreach (var item in sayilar)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
