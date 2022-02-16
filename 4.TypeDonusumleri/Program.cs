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


            string deger = "15";

            int sayi = int.Parse(deger);

            int isayi = 9579;

            byte bsayi = 125;

            bsayi = (byte)isayi;

            Console.WriteLine("ksndlksald: "+bsayi);



            #region DateTime veri tipi

            /*
             
             DateTime 
             
             */

            Console.WriteLine(DateTime.Now);


            DateTime dogumTarihi = new DateTime(1990,5,3,13,45,36);

            Console.WriteLine(dogumTarihi);


            #endregion







        }
    }
}
