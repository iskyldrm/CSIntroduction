using System;

namespace LabOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1;
            int sayi2;
            int sonuc;
            int sonuc1;
            float sonuc2;
            float sonuc3;
            float sonuc4;
            float sayi3;
            float sayi4;


            //// #region Ekrandan Deger Alma
            // /*
            //     Ekrandan değer alma
            //     1- string değer alma
            //     2- sayısal değer alma
            //     */
            // string isim;
            // int yas;
            // int boy;




            // Console.WriteLine("İsminizi Giriniz: ");

            // isim = Console.ReadLine();

            // Console.WriteLine("Yaşınızı Giriniz: ");

            // yas = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Boyunuzu giriniz: ");

            // boy = int.Parse(Console.ReadLine());


            // Console.WriteLine("Girilen İsim: " + isim);
            // Console.WriteLine("Girilen Yaş: " + yas);
            // Console.WriteLine("Girilen Boy: " + boy);
            // #endregion


            //#region 1.soru
            //int sayi1;
            //int sayi2;
            //int sonuc;
            //int sonuc1;
            //float sonuc2;
            //float sonuc3;

            //Console.WriteLine("Birinci sayiyi giriniz :");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İkinci sayiyi giriniz: ");

            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //sonuc = sayi1 + sayi2;
            //sonuc1 = sayi1 - sayi2;

            //sonuc2 = sonuc % sonuc1;

            //sonuc3 = Convert.ToInt32(sonuc2);


            //Console.WriteLine("Sonucunuz: " + sonuc3); 
            //#endregion


            //#region 2.soru
            //Console.WriteLine("Birinci sayiyi giriniz :");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İkinci sayiyi giriniz: ");

            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //sonuc = sayi1 % 2;

            //sonuc1 = sonuc * sonuc;

            //sonuc2 = sayi2 % 2;

            //sonuc3 = sonuc2 * sonuc2;

            //Console.WriteLine("Sonucunuz: " + sonuc1 + " sonucunuz 2: " + sonuc3);
            //#endregion



            //#region 3.soru
            //Console.WriteLine("Birinci sayiyi giriniz :");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İkinci sayiyi giriniz: ");

            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //sonuc = sayi1 * sayi1;
            //sonuc1 = sayi2 * sayi2;

            //sonuc2 = sonuc - sonuc1;

            //Console.WriteLine("Sonucunuz: " + sonuc2);
            //#endregion




            Console.WriteLine("Birinci sayiyi giriniz :");
            sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayiyi giriniz: ");

            sayi4 = Convert.ToInt32(Console.ReadLine());


            sonuc2 = (sayi3 / 10) * 3;

            sonuc3 = (sayi4 / 10) * 7;

            sonuc4 = sonuc2 + sonuc3;

            Console.WriteLine("Sonucunuz: " + sonuc4);













        }
    }
}
