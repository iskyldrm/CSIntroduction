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


            int i;
            int sayi1;
            int sayi2;
            int a=0;
            int b=0;
            



            Console.Write("Birinci sayıyı giriniz: ");

            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");

            sayi2 = int.Parse(Console.ReadLine());

            if (sayi1>sayi2)
            {

                for (i = (sayi2+1); i < sayi1; i++)
                {
                    
                    a = (sayi2 + 1);

                    b = a*a;

                    sayi2++;

                    Console.WriteLine("kareleri " + b);

                }

                




            }














        }
    }
}
