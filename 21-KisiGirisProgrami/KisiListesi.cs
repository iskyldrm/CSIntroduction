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

namespace _21_KisiGirisProgrami
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
            dataGridView1.DataSource = Kisiler;
        }
        List<Kisi> Kisiler = new List<Kisi>();
        private void DosyaOku()
        {
            //1;Ali;Veli;25.02.2022 18:35:44;E;ÖnLisans;100;Fizikçi;;;
            string[] kayitlar = File.ReadAllLines("Kisiler.txt");

            foreach (var kayit in kayitlar)
            {
                string[] data = kayit.Split(";");
                Kisi kisi = new Kisi();
                kisi.Id = int.Parse(data[0]);
                kisi.Ad = data[1];
                kisi.Soyad = data[2];
                kisi.DogumTarihi = Convert.ToDateTime(data[3]);
                kisi.Cinsiyet = Convert.ToChar(data[4]);
                kisi.EgitimDurumu = data[5];
                kisi.Gelir = Convert.ToDecimal(data[6]);
                kisi.Meslek = data[7];
                kisi.MedeniDurum = data[8];
                kisi.Takim = data[9];
                kisi.DogumYeri = data[10];
                
                if(!String.IsNullOrEmpty(data[11]) && data[11].Length>7)
                    kisi.TCKimlik = data[11].Substring(7);

                Kisiler.Add(kisi);

                     
            }

        }
    }
}
