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

            /*
             * string deger;

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
            */

            #endregion

            #region Ay sorusu
            string sayi = " ";

        basla:
            Console.Write("1-12 arası bir sayı giriniz: ");
            sayi = Console.ReadLine();

            Console.WriteLine(" ");


            switch (sayi)
            {
                case "1":
                    Console.WriteLine("Bu ay: Ocak");
                    break;

                case "2":
                    Console.WriteLine("Bu ay: Şubat");
                    break;

                case "3":
                    Console.WriteLine("Bu ay: Mart");
                    break;

                case "4":
                    Console.WriteLine("Bu ay: Nisan");
                    break;

                case "5":
                    Console.WriteLine("Bu ay: Mayıs");
                    break;

                case "6":
                    Console.WriteLine("Bu ay: Haziran");
                    break;

                case "7":
                    Console.WriteLine("Bu ay: Temmuz");
                    break;

                case "8":
                    Console.WriteLine("Bu ay: Ağustos");
                    break;

                case "9":
                    Console.WriteLine("Bu ay: Eylül");
                    break;

                case "10":
                    Console.WriteLine("Bu ay: Ekim");
                    break;

                case "11":
                    Console.WriteLine("Bu ay: Kasım");
                    break;

                case "12":
                    Console.WriteLine("Bu ay: Aralık");
                    break;

                default:
                    Console.WriteLine("Gecersiz değer!!!");

                    goto basla;


            }

            #endregion










        }
    }
}
