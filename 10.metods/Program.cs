using System;


namespace _10.metods
{
    class Program
    {

	
        static void Main(string[] args)
        {
            
            #region çarpma bölme örneği

            //    int sayi1 = degeralma("birinci sayiyi giriniz:");
            //giris:
            //    int sayi2 = degeralma("ikinci sayiyi giriniz:");

            //    int sonuc2 = carpma(sayi1, sayi2);

            //    Console.WriteLine(sonuc2);
            //    try
            //    {


            //        decimal sonuc3 = bolme(sayi1, sayi2);
            //        Console.WriteLine(sonuc3);
            //    }
            //    catch (DivideByZeroException de)
            //    {

            //        Console.WriteLine("Sifira bölme  Hatasi :" + de.Message);
            //        goto giris;

            //    } 
            #endregion

            #region mutlakdeger örneği
            //int sayi1 = degeralma("bir deger giriniz");
            //int sonuc = mutlakdegeralma(sayi1);
            //Console.WriteLine("mutlak değeri: " + sonuc); 
            #endregion

            #region tekmiciftmi örneği
            //int sayi1 = degeralma("bir sayı giriniz");
            //string snc1 = tekmiciftmi(sayi1);
            //Console.WriteLine(snc1);

            #endregion
        }

        #region deger alma
        //static int degeralma(string massege)
        //{
        //    Console.WriteLine(massege);
        //    int alinansayi = int.Parse(Console.ReadLine());
        //    return alinansayi;
        //}
        #endregion



        #region çarpma
        //static int carpma(int sayi1, int sayi2)
        //{
        //    int sonuc = 0;
        //    sonuc = sayi1 * sayi2;

        //    return sonuc;
        //}
        #endregion


        #region bolme
        //static decimal bolme(decimal sayi1, decimal sayi2)


        //{


        //    decimal sonuc = 0;
        //    sonuc = sayi1 / sayi2;

        //    return sonuc;
        //} 
        #endregion

        #region mutlakdegeralma
        //static int mutlakdegeralma(int sayi)
        //{
        //    //int sonuc1 = 0;
        //    if (sayi < 0)
        //    {
        //        return (sayi * (-1));
        //    }
        //    else
        //    {
        //        return sayi;
        //    }

        //} 
        #endregion

        #region tekmiciftmi
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="sayi"></param>
        ///// <returns></returns>
        //static string tekmiciftmi(int sayi)
        //{
        //    string snc = "";
        //    if (sayi % 2 == 0)
        //    {
        //        snc = "çift";
        //        return snc;
        //    }

        //    else
        //    {
        //        snc = "tek";
        //        return snc;
        //    } 
            #endregion

        }



    }
       


    
}
