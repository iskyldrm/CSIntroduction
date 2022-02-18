using System;

namespace _9.Diziler
{
    class Program
    {
        static void Main(string[] args)
        {


            #region diziler konu anlatımı
            //string[] gunler = { "pazartesi", "sali", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(gunler[i]);
            //} 
            #endregion

            #region MyRegion
            //int[] zar = new int[6];
            //Random zarim = new Random();

            ////for (int i = 0; i < 6; i++)
            ////{
            ////    zar[i] = (i + 1);

            ////}

            //Console.WriteLine("Kaç kere atayım: ");

            //int adet = int.Parse(Console.ReadLine());

            //for (int a = 0; a < adet; a++)

            //{

            //    zar[a] = zarim.Next(1, 7);
            //    Console.WriteLine($"gelen deger{a + 1}: " + " " + zar[a]);

            //}

            #endregion

            #region çarpım tablosu
            //int s = 0;

            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 1; j < 11; j++)
            //    {
            //        s = i * j;
            //        Console.Write($"{i}*{j}={s}  ");
            //    }
            //    Console.WriteLine("\n");
            //}

            #endregion

            #region Ornekler

            /*
             
       1.Ay      1 cift
       2.Ay      2 cift
       3.Ay      3 Cift
       4.Ay      5 cift
       5.Ay      8 Cift
       6.Ay      13 Cift
       7.Ay      21 cift
       8.Ay      34 Cift
       9.Ay      55 cift
       10.Ay     89 Cift
       11.Ay     144 
       12.Ay     233 
             */

            //const int ADIM = 12;
            //const string adim = "Ali Veli";

            //int a = 0;
            //int b = 1;
            //int sayi;
            ////Console.WriteLine("Adim Sayisi Giriniz:");
            ////sayi = int.Parse(Console.ReadLine());
            //float oran = 0;
            //Console.WriteLine(
            //"(C) Currency: . . . . . . . . {0:C}\n" +
            //"(D) Decimal:. . . . . . . . . {0:D}\n" +
            //"(E) Scientific: . . . . . . . {1:E}\n" +
            //"(F) Fixed point:. . . . . . . {1:F}\n" +
            //"(G) General:. . . . . . . . . {0:G}\n" +
            //"    (default):. . . . . . . . {0} (default = 'G')\n" +
            //"(N) Number: . . . . . . . . . {0:N}\n" +
            //"(P) Percent:. . . . . . . . . {1:P}\n" +
            //"(R) Round-trip: . . . . . . . {1:R}\n" +
            //"(X) Hexadecimal:. . . . . . . {0:X}\n",
            //-123, -123.45f);
            //Console.WriteLine("{0:D}",10/3);
            //for (int i = 1; i <= sayi; i++)
            //{

            //    //Console.WriteLine(a+" " + b + " "  );
            //    int c = a + b;
            //    Console.WriteLine(c + " ");
            //    a = b;
            //    b = c;
            //    oran = (a + b) / (float)c;
            //    Console.WriteLine("  "+ oran );
            //}

            //Console.ReadLine();


            // Break ;Continue
            int sayac = 0;
            //while (sayac<1000)
            //{

            //    if (sayac < 50)
            //    {

            //        continue;
            //    }
            //    else
            //    {
            //        break;
            //    }


            //}




            // Zar oyunu 

            // 1- Dizi tanimlanir . Dizinin boyutu zarin yuzu kadar olmalidir.
            int[] zar = new int[10];
            // Random degiskenimiz
            Random rnd = new Random();
            //for (int i = 0; i < zar.Length; i++)
            //{
            //    Console.WriteLine(zar[i]);
            //}
            int gelenDeger = 0;

            // 1000 kere denenecek
            for (int i = 1; i <= 1000; i++)
            {

                gelenDeger = rnd.Next(1, 7); // Zar attigimiz yer. 0-5 arasi bir deger uretir

                if (gelenDeger == 0)
                    Console.WriteLine("Sifir Geldi");


                zar[gelenDeger] += 1; // 3 geldiyse zar[3]+=1;
            }
            for (int i = 0; i < zar.Length; i++)
            {
                Console.WriteLine(zar[i]);
            }
            int toplam = 0;
            for (int i = 0; i < zar.Length; i++)
            {
                toplam += zar[i];
                Console.WriteLine(zar[i] / 1000f);
            }
            Console.WriteLine("Toplam:" + toplam);
            // Console.ReadKey();
            //for (int i = 0; i < 20; i++)
            //{
            //        continue;
            //    Console.WriteLine(i);
            //}


            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }

            /*
             1x1=1
             1x2=2
             
                int[] sayilar = { 6, 9, 7, 5, 12 ,2};
             
             */

            int[] sayilar = { 6, 9, 7, 5, 12, 2 };
            int enBuyuk, enKucuk;
            enBuyuk = 0;
            enKucuk = sayilar[0];
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > enBuyuk)
                    enBuyuk = sayilar[i];
                if (enKucuk > sayilar[i])
                    enKucuk = sayilar[i];

            }

            Console.WriteLine("En Kucuk :" + enKucuk);
            Console.WriteLine("En Buyuk :" + enBuyuk);

            #endregion
            Console.WriteLine("Hello World!");


            // Cok Boyutlu diziler
            int[,] matris = new int[3, 3]; // iki boyutlu dizi
            int[,,] matris3 = new int[3, 3, 3]; // 3 boyutludizi


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matris[i, j] = rnd.Next(1, 101);
                }
            }

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }








        }
    }
}
