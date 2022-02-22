using System;

namespace _12_RefVeOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ref kullanırken varsayılan değer ataması zorunludur,
            // Out için bu zorunluluk yoktur.

            //Metot’a out anahtar sözcüğü ile geçilen değişkenin aynı metot içinde
            // değer ataması yapılması zorunlu iken, Ref için böyle bir zorunluluk yoktur.

            // ref disaridakinin referansini alir,
            // out ise iceride yeni bir eleman deklere edilir  ve
            // onun referansi disaridakine atanir ;
            int a, b, sayi, deger;
            a = 5;
            b = 3;
            Console.WriteLine("B degeri :" + b);
            int toplam = testTopla(a, ref b);
            Console.WriteLine("Toplam:" + toplam + " B DEgeri :" + b);
            int[] sayilar = { 1, 2, 3, 4, 5 };

            //dizinin boyutunu degistirir
            DiziBoyutuBuyut(ref sayilar, 10);

            string str = "5";
            bool donustumu = false;

            donustumu = KontrolluSayiAl(str, out sayi);

            Console.WriteLine("Hello World!");
        }

        public static bool KontrolluSayiAl(string str, out int deger)
        {
            try
            {
                deger = int.Parse(str);
                return true;
            }
            catch (Exception ex)
            {
                deger = 0;
                return false;
            }
        }

        public static int testTopla(int sayi1, ref int sayi2)
        {
            sayi2 = 5;
            return sayi1 + sayi2;
        }
        public static void DiziBoyutuBuyut(ref int[] sayidizisi, int uzunluk)
        {
            int[] yeniDizi = new int[uzunluk];
            try
            {
                for (int i = 0; i < sayidizisi.Length; i++)
                {
                    yeniDizi[i] = sayidizisi[i];
                }

                sayidizisi = yeniDizi; //referans atanmasi yapilir
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata:" + ex.Message);
            }
        }
    }
}