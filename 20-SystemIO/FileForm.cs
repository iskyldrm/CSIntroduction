using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_SystemIO
{
    public struct Kisi
    {

        public string Ad;
        public string Soyad;
        public DateTime DogumTarihi;
        public char Cinsiyet;
        public string EgitimDurumu;
        public decimal Gelir;
        public string Meslek;
        public string MedeniDurum;
        public string Takim;
        public string DogumYeri;
    }

    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // File sinifi static bir siniftir
            // 
            File.CreateText(@"c:\deneme.txt");
            Kisi kisi = new Kisi();  //instance aliyoruz

            kisi.Ad = txtAd.Text;
            kisi.Soyad= txtSoyad.Text;
            kisi.DogumTarihi= dtDogumTarihi.Value;
            
            kisi.Cinsiyet= rdrKadin.Checked==true ? 'K' : 'E';

            kisi.EgitimDurumu = cmbEgitim.Text;
            kisi.Gelir = nmGelir.Value;
            kisi.Meslek = cmbMeslek.Text;
            kisi.MedeniDurum = cmbMedeniDurum.Text;
            kisi.Takim= cmbTakim.Text;
            kisi.DogumYeri = cmbDogumYeri.Text;
            
        }
    }
}
