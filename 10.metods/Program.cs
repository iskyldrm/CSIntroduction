using System;

namespace _10.metods
{
    class Program
    {

	
        static void Main(string[] args)
        {
        
            int sayi1 = degeralma("birinci sayiyi giriniz:");
        giris:
            int sayi2 = degeralma("ikinci sayiyi giriniz:");

            int sonuc2 = carpma(sayi1,sayi2);

            Console.WriteLine(sonuc2);
            try
            {


                decimal sonuc3 = bolme( sayi1, sayi2);
                Console.WriteLine(sonuc3);
            }
            catch (DivideByZeroException de)
            {

                Console.WriteLine("Sifira bölme  Hatasi :" + de.Message);
                goto giris;

            }
            

           
            

        }

        #region sayı alma
        static int degeralma(string massege)
        {
            Console.WriteLine(massege);
            int alinansayi = int.Parse(Console.ReadLine());
            return alinansayi;
        } 
        #endregion



        #region çarpma
        static int carpma(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 * sayi2;

            return sonuc;
        }
        #endregion


        #region bolme
        static decimal bolme(decimal sayi1, decimal sayi2)


        {


            decimal sonuc = 0;
            sonuc = sayi1 / sayi2;

            return sonuc;
        } 
        #endregion





    }
       


    
}
