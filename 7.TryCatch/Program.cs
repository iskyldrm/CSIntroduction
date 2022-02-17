using System;

namespace _7.TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

        #region Konu Anlatimi 
        /*
         Hatalar 3'e ayrilir
        1- Syntax Hatasi 
        2-Runtime Hatasi - Çalişma Zamani Hatasi 
            örnek olarak sifira bolme hatsi yada tip donusum hatasi verilebilir
        3-Mantik hatasi : Programcinin yaptigi hatadir 
          Debug yontemi ile çözülebilir.
        Hatalari yakalamak icib try-catch yapisi kullanilir
        try 
        {
          Programin akişinin gittigi yerdir.
          Hata olursa catc
        h bloguna düşecektir
         ......
        }
        catch (Exception ex)
        {
          Burasi hatayi yakaladigimiz yerdir
         ......
        }
        finaly 
        {
            //Burasi hata olsun olmasin mutlaka calisan bolumdur.
        }
         */

        #endregion


        #region Örnek
        giris:
            try
            {
                Console.WriteLine("Birinci Sayiyi Giriniz:");
                byte sayi1 = byte.Parse(Console.ReadLine());
                Console.WriteLine("ikinci Sayiyi Giriniz:");
                byte sayi2 = byte.Parse(Console.ReadLine());
                int sonuc = sayi1 / sayi2;

                Console.WriteLine("sonuc: "+sonuc);

            }
            catch (FormatException fe)  // Format hatasi
            {

                Console.WriteLine("Formatlama Hatasi :" + fe.Message);
                goto giris;
            }
            catch (DivideByZeroException de) // Sifira bolme hatasi
            {

                Console.WriteLine("Sifira bölme  Hatasi :" + de.Message);
                goto giris;
            }
            catch (OverflowException oe) // Taşma hatasi
            {

                Console.WriteLine("Taşma Hatasi :" + oe.Message);
                goto giris;
            }
            catch (Exception ex) // Geri kalan ne varsa 
            {

                Console.WriteLine("Bilinmeyen  Hata:" + ex.Message);
                goto giris;
            }
            #endregion




        }
    }
}
