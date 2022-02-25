using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_HazirMetodlar
{
    public partial class MathForm : Form
    {
        public MathForm()
        {
            InitializeComponent();
        }

        // MAth sinifi onlarca matematik fonksiyonunu hazir olara
        // bize verir
        private void btnPi_Click(object sender, EventArgs e)
        {
            label1.Text = Math.PI.ToString();
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            // Mutlak degeri verir
            label1.Text = Math.Abs(-5).ToString();
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            //Verilen ondalkli sayiyi aşğı yuvarlar
            label1.Text = Math.Floor(12.98).ToString();
        }

        private void btnCeiling_Click(object sender, EventArgs e)
        {
            //Verilen ondalkli sayiyi yukari yuvarlar
            label1.Text = Math.Ceiling(12.01).ToString();
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //Verilen ondalkli sayiyi duruma göre yuvarlar
            //. önceki sayi çift ise bir alta ,tek ise bir uste yuvarlar

            label1.Text = Math.Round(48.50).ToString();
        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            //Verilen ondalikli sayiyin ondalik kismini kirpar


            label1.Text = Math.Truncate(48.50).ToString();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            //Verilen  sayiyin kuvvetini alir
            label1.Text = Math.Pow(2, 4).ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            //Verilen  sayiyin karekokunu alir
            label1.Text = Math.Sqrt(15).ToString();

        }

        private void btnSing_Click(object sender, EventArgs e)
        {
            //Verilen  sayiyin işaretini verir
            //Eger negatif ise -1 , pozitif 1 
            label1.Text = Math.Sign(15).ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //Verilen  2 sayinin en kucugunu verir 
            label1.Text = Math.Min(3, 5).ToString();
        }

        private void btnUcSayi_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);
            int sayi3 = int.Parse(txtSayi3.Text);
            label1.Text = Math.Min(Math.Min(sayi1, sayi2), sayi3).ToString();


        }
    }
}