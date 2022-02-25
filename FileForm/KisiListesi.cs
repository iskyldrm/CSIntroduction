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

namespace FileForm
{
    public partial class KisiListesi : Form
    {
        public KisiListesi()
        {
            InitializeComponent();
        }

        private void KisiListesi_Load(object sender, EventArgs e)
        {
            DosyaOku();
            dataGridView1.DataSource = Kisiler.ToList();
        }

        List<Kisi> Kisiler = new List<Kisi>();

        private void DosyaOku()
        {
            //1;iasda;aldşa;25.02.2022 18:35:39;E;Orta Okul;3;Avukat Yardımcısı;Dul;Başakşehir	; Adıyaman;

             string[] kayitlar =  File.ReadAllLines("kisiler.txt");

            foreach (var kayit in kayitlar)
            {
                string[] data = kayit.Split(';');

                Kisi kisi = new Kisi();

                kisi.Id = int.Parse(data[0]);
                kisi.Ad = data[1];
                kisi.Soyad = data[2];
                kisi.Dogumtarihi = Convert.ToDateTime(data[3]);
                kisi.Cinsiyet = Convert.ToChar(data[4]);
                kisi.Egitimdurum = data[5];
                kisi.Mesleki = data[6];
                kisi.Medenisi = data[7];
                kisi.Takimi = data[8];
                kisi.Memleketi = data[9];
                kisi.Gelirler = Convert.ToDecimal(data[10]);

            }


        }
    }
}
