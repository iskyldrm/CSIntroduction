using System;

namespace _13_ArraySinifiVeMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {

            // Array Sinifi Microsoft tarafindan yazilmis bir sinif ve
            // .Net kutupanesi icerisinde hazir bulur.

            string[] sehirler = { "Adana", "Muş", "Van", "Ankara", "Amasya", "Bolu", "Istanbul", "Izmir", "Samsun", "Bolu", "Zonguldak" };

            string[] yeniSehirler = { "Izmir", "Samsun", "Muş", "Van", "Zonguldak" };


            #region Clear 
            //Clear metodu diziden eleman silmeye yarar.
            //Array.Clear(sehirler, 0, 2);
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //} 
            #endregion

            #region Copy


            //Copy => bir diziden ,baska bir diziye kopyalama yapar

            //Array.Copy(sehirler, yeniSehirler,4);

            //for (int i = 0; i < yeniSehirler.Length; i++)
            //{
            //    Console.WriteLine(yeniSehirler[i]);
            //} 
            #endregion

            #region  IndexOf
            // dizide aradigimiz elemanin index degerini verir
            // Eger aradigimiz deger dizide yoksa -1 doner .
            // Eger birden fazla bulursa ilk buldugu index'i gonderir

            //int index = Array.IndexOf(sehirler, "Ankara");
            //int index2 = Array.IndexOf(sehirler, "Bolu");
            //int index3 = Array.IndexOf(sehirler, "Berlin");
            #endregion

            #region LastIndexOf
            //int index = Array.LastIndexOf(sehirler, "Bolu");
            //Console.WriteLine("Bolu dizi icerisinde en son index'i :" + index);
            #endregion
            #region Siralama
            //Sort => dizinin A'dan Z'ye dogru siralamasini yapar.
            //Dikkat : siralama degistiginden , index numaralarida degisir.
            //Array.Sort(sehirler);

            //int[] sayilar = { 1, 2, 4 };
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region  Reverse
            // Diziyi tersine cevirir
            //Array.Reverse(sehirler);
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Resize
            //Array.Resize(ref sehirler, 20);
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Doldurma
            Array.Fill(yeniSehirler, "Berlin");
            foreach (var item in yeniSehirler)
            {
                Console.WriteLine(item);
            }
            #endregion


        }
    }
}