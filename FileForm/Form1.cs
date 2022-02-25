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
    public struct Kisi
    {
        public string Ad;
        public string Soyad;
        public DateTime Dogumtarihi;
        public char Cinsiyet;
        public string Egitimdurum;
        public decimal Gelirler;
        public string Mesleki;
        public string Medenisi;
        public string Takimi;
        public string Memleketi;



    }

    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //File.CreateText(@"deneme.txt");


            Kisi kisi = new Kisi(); //instance almak



            kisi.Ad = txtAdi.Text;

            kisi.Soyad = txtSoyadi.Text;

            kisi.Dogumtarihi = dateTimePicker1.Value;

            kisi.Cinsiyet = radioButton1.Checked == true ? 'K' : 'E';

            kisi.Egitimdurum = EgitimDurumu.Text;

            kisi.Gelirler = UPgelir.Value;

            kisi.Mesleki = Combomeslek.Text;

            kisi.Medenisi = comboMedeni.Text;

            kisi.Takimi = comboBox1.Text;

            kisi.Memleketi = comboBox2.Text;

            StringBuilder builder = new StringBuilder();

            builder.Append(kisi.Ad+";");
            builder.Append(kisi.Soyad + ";");
            builder.Append(kisi.Dogumtarihi + ";");
            builder.Append(kisi.Cinsiyet + ";");
            builder.Append(kisi.Egitimdurum + ";");
            builder.Append(kisi.Gelirler + ";");
            builder.Append(kisi.Mesleki + ";");
            builder.Append(kisi.Medenisi + ";");
            builder.Append(kisi.Takimi + ";");
            builder.Append(kisi.Memleketi + ";");

            DosyayaYaz(builder.ToString());


        }

        public bool DosyayaYaz(string kayit)
        {
            StreamWriter writer = File.AppendText("kisiler.txt");
            writer.WriteLine(kayit);
            writer.Close();

            return true;
        }
    }
}
