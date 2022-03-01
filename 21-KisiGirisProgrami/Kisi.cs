using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_KisiGirisProgrami
{
    public struct Kisi
    {
        // public int Id;
        // public string Ad;
        //  public string Soyad;
        //  public DateTime DogumTarihi;
        //public char Cinsiyet;
        // public string EgitimDurumu;
        // public decimal Gelir;
        // public string Meslek;
        // public string MedeniDurum;
        // public string Takim;
        // public string DogumYeri;
        //private int id;
        //public int Id 
        //{ 
        //    get { return id; }
        //    //Sadece bulundugumuz struct icerisinden atama yapilabilir
        //    //private set { id = value; } 
        //}


        public int Id { get; set; }
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime DogumTarihi { get; set; }

        public char Cinsiyet { get; set; }

        public string TCKimlik { get; set; }
        //public string TcKimlik 
        //{
        //    get {

        //        if (!String.IsNullOrEmpty(TcNo))
        //            return TcNo.Substring(7);
        //        else
        //            return "";
        //    }
        //    set { 
        //        if (value.Length == 11)
        //        {
        //            TcNo = value;
        //        }
        //    }
        //}

        public string EgitimDurumu { get; set; }
        public decimal Gelir { get; set; }
        public string Meslek { get; set; }

        public string MedeniDurum { get; set; }


        public string Takim { get; set; }
        public string DogumYeri { get; set; }
        //public void SetTcNo(string tcno)
        //{
        //    if (tcno.Length == 11)
        //    {
        //        TcNo = tcno;
        //    }
        //}
        //public string GetTcNo(string tcno)
        //{
        //    return TcNo.Substring(7);
        //}


        public bool DosyayaKaydet()
        {
            StringBuilder satir = new StringBuilder();
            Id = SonIdBul("Kisiler.txt");
            satir.Append(Id + ";");
            satir.Append(Ad + ";");
            satir.Append(Soyad + ";");
            satir.Append(DogumTarihi + ";");
            satir.Append(Cinsiyet + ";");
            satir.Append(EgitimDurumu + ";");
            satir.Append(Gelir + ";");
            satir.Append(Meslek + ";");
            satir.Append(MedeniDurum + ";");
            satir.Append(Takim + ";");
            satir.Append(DogumYeri+";");
            satir.Append(TCKimlik);

            StreamWriter writer = File.AppendText("Kisiler.txt");
            writer.WriteLine(satir);

            writer.Close();

            return true;
        }
        private int SonIdBul(string dosyaAdi)
        {
            int Id = 0;
            bool durum = false;


            // Dosya Var ise
            if (File.Exists(dosyaAdi))
            {
                string[] kayitlar = File.ReadAllLines(dosyaAdi);

                if (kayitlar.Length > 0)
                {
                    // 1;Ali;Veli;01.01.1900;E 
                    foreach (var kayit in kayitlar)
                    {
                        string[] veri = kayit.Split(";");
                        durum = int.TryParse(veri[0], out Id);
                    }
                }
            }



            return ++Id;
        }
    }
}
