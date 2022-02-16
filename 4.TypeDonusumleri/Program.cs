using System;

namespace _4.TypeDonusumleri
{
    class Program
    {
        /*
         .NET'te iki tip tür dönüşümü vardır

        1- kapalı donüşüm (implicit conversion)
        2- acık donüşüm   (Explicit conversion)

         
         */

        static void Main(string[] args)
        {

            //convert sınıfı tip donusumu için kullanılan .NET içerisindeki sınıftır
            //to ile başlayan metodlar kullanılabilir

            //bool,byte,char,datetime,decimal ve parse metodlarıda kullanılır.


            #region Type Convertion
            string deger = "127";

            //int sayi = int.Parse(deger);

            
            sbyte sbyte1;

            int isayi = 6000;

            byte bsayi = 125;

            bsayi = (byte)isayi; //her 256 da bir tekrar birden başlayarak devam eder

            Console.WriteLine("ksndlksald: " + bsayi);

            //int, sbyte, byte,short,long

            isayi = Convert.ToInt16(deger);

            Console.WriteLine("int Çevrilen sayi: {0}",deger);

            sbyte1 = (sbyte)isayi;

            //sbyte1 = Convert.ToSByte(sayi1);

            Console.WriteLine("sbyte Çevrilen sayi: {0}", sbyte1);


            









            #endregion
            #region DateTime veri tipi

            /*
             
             DateTime 
             
             */

            //Console.WriteLine(DateTime.Now);


            //DateTime dogumTarihi = new DateTime(1990,5,3,13,45,36);

            //Console.WriteLine(dogumTarihi);


            #endregion







        }
    }
}
