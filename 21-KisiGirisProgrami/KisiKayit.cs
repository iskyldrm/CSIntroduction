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
    public partial class KisiKayit : Form
    {

        
        public KisiKayit()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // File sinifi static bir siniftir
            // 
          
            Kisi kisi = new Kisi();  //instance aliyoruz
            
            kisi.Ad = txtAd.Text;
            kisi.Soyad = txtSoyad.Text;
            kisi.DogumTarihi = dtDogumTarihi.Value;
            kisi.Cinsiyet = rdrKadin.Checked == true ? 'K' : 'E';
            kisi.EgitimDurumu = cmbEgitim.Text;
            kisi.Gelir = nmGelir.Value;
            kisi.Meslek = cmbMeslek.Text;
            kisi.MedeniDurum = cmbMedeniDurum.Text;
            kisi.Takim = cmbTakim.Text;
            kisi.DogumYeri = cmbDogumYeri.Text;
            //kisi.SetTcNo(txtTcno.Text);
            kisi.TCKimlik = txtTcno.Text;


            #region Dosya Formati olusumu
            //StringBuilder satir = new StringBuilder();
            //kisi.Id= SonIdBul("Kisiler.txt");
            //satir.Append(kisi.Id + ";");
            //satir.Append(kisi.Ad + ";");
            //satir.Append(kisi.Soyad + ";");
            //satir.Append(kisi.DogumTarihi + ";");
            //satir.Append(kisi.Cinsiyet + ";");
            //satir.Append(kisi.EgitimDurumu + ";");
            //satir.Append(kisi.Gelir + ";");
            //satir.Append(kisi.Meslek + ";");
            //satir.Append(kisi.MedeniDurum + ";");
            //satir.Append(kisi.Takim + ";");
            //satir.Append(kisi.DogumYeri);
            //satir.Append(kisi.TcKimlik);
            #endregion


          bool kayitsonucu=  kisi.DosyayaKaydet();
            EkraniTemizle();
            if (kayitsonucu)
                MessageBox.Show("Kayit Islemi Basari ile gerceklesmistir. Inanmazsan Kişi listesi nden kontrol edebibirsiniz.");
            else
                MessageBox.Show("Beklenmedik bir hata olustu");
        }


        public void EkraniTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTcno.Text = "";
            rdrErkek.Checked = false;
            rdrKadin.Checked = false;
            dtDogumTarihi.Value = DateTime.Now;
            cmbDogumYeri.SelectedIndex = 0;
            cmbEgitim.SelectedIndex = 0;
            cmbMedeniDurum.SelectedIndex = 0;
            cmbTakim.SelectedIndex = 0;
            cmbMeslek.SelectedIndex = 0;
            nmGelir.Value = 0;
        }

        string[] kisiler = { "Ali:1", "Veli:1", "Ayse:2", "Fatma:2", "Hasan:1", "Huseyin:1", "Zeynep:2", "Ahmet:1", "Sude:2", "Deniz:1", "Kagan:1", "Ahu:2", "Fadime:2" };

        string[] soyadlar = { "Yilmaz", "Yildirim", "Kaya", "Sari", "Taş", "Öztürk", "Bayraktar" };

        private void FileForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();


            //int random =  rnd.Next(0, cmbEgitim.Items.Count);
            for (int i = 0; i < 10000; i++)
            {
                string tcno = "";
                Kisi yenikisi = new Kisi(); 
           
                    cmbEgitim.SelectedIndex= rnd.Next(0, cmbEgitim.Items.Count);
                    cmbDogumYeri.SelectedIndex = rnd.Next(0, cmbDogumYeri.Items.Count);
                    cmbMedeniDurum.SelectedIndex= rnd.Next(0, cmbMedeniDurum.Items.Count);
                    cmbMeslek.SelectedIndex = rnd.Next(0, cmbMeslek.Items.Count);
                    cmbTakim.SelectedIndex= rnd.Next(0, cmbTakim.Items.Count);
                    nmGelir.Value = rnd.Next(5000, 20000);
                   string kisi = kisiler[rnd.Next(0, kisiler.Length)];
            
                    txtAd.Text = kisi.Split(":")[0];
                    if (kisi.Split(":")[1] == "1")
                        rdrErkek.Checked = true;
                    else
                        rdrKadin.Checked = true;
                    txtSoyad.Text = soyadlar[rnd.Next(0, soyadlar.Length)];

                    for (int j = 0; j < 11; j++)
                    {
                        tcno += rnd.Next(0, 10).ToString();
                    }
                    txtTcno.Text = tcno;

                yenikisi.MedeniDurum = cmbMedeniDurum.Text;
                yenikisi.Meslek = cmbMeslek.Text;
                yenikisi.Takim = cmbTakim.Text;
                yenikisi.TCKimlik = txtTcno.Text;
                yenikisi.DogumYeri = cmbDogumYeri.Text;
                yenikisi.Cinsiyet = rdrErkek.Checked==true ? 'E' : 'B';
                yenikisi.Ad = txtAd.Text;
                yenikisi.Soyad = txtSoyad.Text;
                yenikisi.Gelir = nmGelir.Value;
                yenikisi.DogumTarihi = new DateTime(rnd.Next(1980, 2002), rnd.Next(1, 13), rnd.Next(1, 28));
                yenikisi.EgitimDurumu = cmbEgitim.Text;
                yenikisi.DosyayaKaydet();
            }
        }
    }
}
