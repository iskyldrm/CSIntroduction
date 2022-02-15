

using System;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DENEME");
            Console.WriteLine("DENEME");
           

            #region Degiskenleri Tanımla Kuralları
            /* 
            1- Kullanmayacagınız degiskenleri taimlamayiniz
            2- Deger aralıklarına göre degiskenleri tanımlayınız.
            3- Degısken adları asla sayi ile başlayamaz.



             */

            #endregion
           
            #region Tamsyi değiskenler
            //Veri tipi DegiskenAdi = İlkdegeratamasi

            //-111 1111 --> baştaki bit işaret bitidir ( - mi + mı)
            //sbyte ==> 8 bit = 1 byte
            //max = 127
            //min = -128
            sbyte DegiskenSbyte = 25;

            //byte ==> 8 bit 0-255
            //max = 255
            //min = 0
            byte DegiskenByte = 136;


            //short ==> 16 bit
            //max deger = 32767
            //min deger = -32768
            short DegiskenShort = 32221;

            //ushort ==> 16 bit
            //max deger = 65535
            //min deger = 0
            ushort DegiskenUshort = 32221;


            //int ==> 32 bit
            //max : 2.1 milyar
            //min : -2.1 milyar
            int DegiskenInt = 354646316;


            //int ==> 32 bit
            //max : 2.1 milyar
            //min : -2.1 milyar
            int DegiskenInt2 = -354646316;


            //uint ==> 32 bit
            //max : 4.2 milyar
            //min : 0 milyar
            uint DegiskenUint = 354646316;


            //long => 64 bit
            //max deger : 9.2 katrilyon
            //min deger : -9.2 katriyon
            long DegiskenLong = 445466948646;


            //ulong => 64 bit
            //max = 18.4 kariyon
            //min = 0
            ulong DegiskenUlong = 54684165461165;
            #endregion

            #region Ondalikli Degiskenler

            //float => 32 bittir 4 byte yapar
            //.'dan sonra 7 hane alır
            float DegiskenFloat = 1.23456789f;


            //double => 64 bit yani 8 bytetir
            //.'dan sonra 13 ile 14 tane desteği vardır
            double DegiskenDouble = 2.649864649846466666666;

            //decimal => 128 bit = 16 byte
            //.'dan sonra 27-28 hane desteği vardır
            decimal DegiskenDecimal = 5.64978466496646464m;








            #endregion

            #region Metinsel Veri tipi

            //char => uzerinde 1 adet karekter barindiran vari tipidir
            char DegiskenChar = 'Ğ'; // 16 bit UniCode Karekter


            //string => Uzerinde istediğimiz kadar veri tutabileceğimiz alandır

            string DegiskenString = "dasmdasdmoaspakcasfkposakfpsamcvpafsa" 
                + "skasşkfasfasfşaskfoaskfaskfaskfascf" 
                + "dlasldlaksdalsda";

            string str = "Bugun Gunlerde Sali";

            //str = "su anda  \fenerbahce universtesindeyim\"";

            Console.WriteLine(str);




            #endregion
  
            #region Mantiksal Veri Tipi

            //bool veir tipi kullanılır

            bool KayitVarmi = false;

            bool Buyukmu = true;

            bool kucukmu = 10 < 5;
            Console.WriteLine("sonuc : " + kucukmu.ToString());


            #endregion


            Console.ReadLine();

        }
    }
}
