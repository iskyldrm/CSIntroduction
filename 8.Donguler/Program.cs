using System;

namespace _8.Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            #region örnekler
            //int i=1;
            //int sonuc = 0;

            /*
             * for(i=1; i<=100; i++)
            {
                sonuc = sonuc + i;
            }
            Console.WriteLine("sonuc: "+sonuc);
            */

            /*
            while(i<101)
            {
                sonuc = sonuc + i;
                i++;
            }
            Console.WriteLine("sonuc: " + sonuc);
            */


            //do
            //{
            //    sonuc = sonuc + i;
            //    i++;
            //}
            //while (i < 101);

            //    Console.WriteLine("sonuc: " + sonuc); 
            #endregion


            #region 1.soru

            //0-100 arasında ki 3 ve yediye bölünenleriin toplamını ekrana yazıdr

            //int i = 0;
            //int s3 = 0;
            //int s7 =0;

            //while (i <= 100)
            //{
            //    if (i%3==0)
            //    {
            //        s3 = s3 + i;
            //    }
            //    if (i%7 == 0)
            //    {
            //        s7 = s7 + i;
            //    }
            //    i++;

            //}
            //Console.WriteLine("s3 toplamı: {0}", (s3+s7));
            ////Console.WriteLine("s7 toplamı: {0}", );




            #endregion

            #region 6.soru
            /*int sayi1 = 0;
            int sayi2 = 0;

            int s1 = 0;
            int s2 = 0;


            int a = 0;
            int b = 0;

            int i = 0;


        basla:
            try
            {
                Console.WriteLine("birinci sayıyı giriniz: ");
                sayi1 = int.Parse(Console.ReadLine());

                Console.WriteLine("ikinci sayıyı giriniz: ");
                sayi2 = int.Parse(Console.ReadLine());

                if (sayi1 > sayi2)
                {
                    a = sayi2 + 1;
                    b = sayi1 - 1;
                    Console.WriteLine("sayılar     Karesi      Küpü");
                    for (i = a; i <= b; i++)

                    {
                        s1 = i * i;
                        s2 = i * i * i;

                        Console.Write("    {0}", i);
                        Console.Write("        {0}", s1);
                        Console.Write("        {0}", s2);
                        Console.WriteLine("");


                    }
                    goto basla;

                }

                else if (sayi1 < sayi2)
                {
                    a = sayi2 - 1;
                    b = sayi1 + 1;
                    Console.WriteLine("sayılar     Karesi   Küpü");

                    for (i = b; i <= a; i++)

                    {
                        s1 = i * i;
                        s2 = i * i * i;

                        Console.Write("    {0}", i);
                        Console.Write("        {0}", s1);
                        Console.Write("          {0}", s2);
                        Console.WriteLine("");


                    }
                    goto basla;
                }
                else
                {
                    Console.WriteLine("Eşit sayılar arasında sayımı olur!!");
                    goto basla;
                }

            }
            catch (FormatException fe) // Format hatasi
            {

                Console.WriteLine("Formatlama Hatasi :" + fe.Message);
                goto basla;
            }

            catch (OverflowException oe) // Taşma hatasi
            {

                Console.WriteLine("Taşma Hatasi :" + oe.Message);
                goto basla;
            }
            catch (Exception ex) // Geri kalan ne varsa 
            {

                Console.WriteLine("Bilinmeyen  Hata:" + ex.Message);
                goto basla;
            }
            */
            #endregion

            int a = 0;
            int b = 1;
            int c = 0;
            float d = 0;


            for (int i = 0; i<= 30; i++)
            {
                
                c = a + b;

                a = b;
                b = c;

                d = (a+b) / (float)c;
                

            Console.WriteLine("-" + b +" "+ d );
            }

            

        }
    }
}