using System;

namespace _6.Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {



            #region Tanim
            /*
             Switch - Case if-else mantigla çalisir.  Arasindaki farl , if-else yapisi buyukluk ,kucukluk gibi durumlari kontrol edrken , yanlizca eşitlik durumlarini kontrol eder.  Kendisine bir index yapisi vardir. Bu index'e gore siraya koyar ve otomatik olarak onlarca yada yuzlerce  kosulumuz olsa bile herbirine ugramadan uygun olann kosula gider. Buda performans acisindan onemlidir.
             
            Switch blogu icerisine yazdigimiz veri tipi ne ise case (durum) olarak belirttigimiz tüm veriler 
            de ayni tipten olmak zorundadir.
            break => kosul saglandi ve karar yapisini kirar .
             */

            string deger;

            Console.Write("Mevsim Giriniz:");
            deger = Console.ReadLine();
            switch (deger)
            {
                case "Kiş":
                    Console.WriteLine("Aralik-Ocak-Subat");
                    break;
                case "ilkbahar":
                    Console.WriteLine("Mart-Nisan-Mayis");
                    break;
                case "yaz":
                    {
                        Console.WriteLine("Haziran-Temmuz-Agustos");
                    }
                    break;
                default:
                    Console.WriteLine("Eylul-Ekim-Kasim");
                    break;
            }

            #endregion

            Console.WriteLine("Hello World!");
        }
    }
}
