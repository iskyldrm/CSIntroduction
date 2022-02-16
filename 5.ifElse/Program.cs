using System;

namespace _5.ifElse
{
    class Program
    {
        static void Main(string[] args)
        {


            #region ifElse Anlatımı
            /*
                  şartlı scope if ile başlar diğer şartlar için else if kullanılır
                  en osnunda else kısmında ise sadce bir scope çalıştıırlır.

              1- kullanımı

                  if(koşul)
              {
                  koşul doğru ise bu scope çalışır          
              }

              2- kullanım

                if(koşul)
              {
                  koşul doğru ise bu scope çalışır          
              }
              else (koşul2)
              {
                  koşul false olduğu durumda burası çalışacaktır.
              }

              3- kullanım

                if(koşul)
              {
                  koşul doğru ise bu scope çalışır          
              }
              else if(koşul3)
              {
                  koşul false olduğu durumda burası çalışacaktır.
              }


               */
            #endregion

            //ÖRNEKLER

            #region 1.soru


            /*int sayi;

            Console.WriteLine("1 ile 7 arasında sayı giriniz: ");

            sayi = Convert.ToByte(Console.ReadLine());

            if (sayi == 1)
            {
                Console.WriteLine("Girilen sayıya göre bugün: Pazartesi");
            }

            else if (sayi == 2)
            {
                Console.WriteLine("Girilen sayıya göre bugün: Salı");
            }

            else if (sayi == 3)
            {
                Console.WriteLine("Girilen sayıya göre bugün: Çarşamba");
            }

            else if (sayi == 4)
            {
                Console.WriteLine("Girilen sayıya göre bugün: Perşembe");
            }

            else if (sayi == 5)
            {
                Console.WriteLine("Girilen sayıya göre bugün: Cuma");
            }

            else if (sayi == 6)
            {
                Console.WriteLine("Girilen sayıya göre bugün: Cumartesi");
            }
            else if (sayi == 7)
            {
                Console.WriteLine("Girilen sayıya göre bugün: Pazar");
            }

            else if (sayi > 7 || sayi < 1)
            {
                Console.WriteLine("1-7 ARASINDA BİR SAYI GİRMELİYDİNİZ!!!!!!!!");
            }
            */
            #endregion

            #region 2.soru
            int sayi =0;
            string deger ="";
            bool donusme;

            basla:

            Console.WriteLine("1 ile 24 arasında sayı giriniz: ");

            deger = Console.ReadLine();

            

            donusme = int.TryParse(deger, out sayi);

            //sayi = Convert.ToByte(Console.ReadLine());

            if (donusme==true)
            {
                if (sayi >= 4 && sayi <= 10)
                {
                    Console.WriteLine("Girilen sayıya göre şuan: Sabah");
                }

                else if (sayi >= 11 && sayi <= 13)
                {
                    Console.WriteLine("Girilen sayıya göre şuan: Öğlen");
                }

                else if (sayi >= 14 && sayi <= 18)
                {
                    Console.WriteLine("Girilen sayıya göre şuan: İkindi");
                }

                else if (sayi >= 19 && sayi <= 21)
                {
                    Console.WriteLine("Girilen sayıya göre şuan: Akşam");
                }

                else if (sayi >= 22 && sayi < 4)
                {
                    Console.WriteLine("Girilen sayıya göre şuan: Gece");
                }

                /*
                else if (sayi > 24 || sayi < 1)
                {
                    Console.WriteLine("1-24 ARASINDA BİR SAYI GİRMELİYDİNİZ!!!!!!!!");
                }
                */

            }
            else
            {
                goto basla;
            }

            
            #endregion


            

        }
    }
}
