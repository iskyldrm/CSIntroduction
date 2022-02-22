using System;
using System.Collections;

namespace _14_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Konu Anlatimi : Simdiye kadar gordugumuz dizlerin özelligi
             Tip Bagimliligi , Digeri ise boyut.
            ArrayList ile bu bagimliklar ortadan kalkar .
            Bir arraylist tanimlandiginda herhangi bir boyut yada tip 
            belirtmek zorunda degilsiniz. 
            ArrayList'i boş bir çuval gibi düşünebilirsiniz.
            ArrayListler object turunden degerler alirlar. 
            O nedenle ArrayList icerisinde bir index'ten veri almak istedigimizde 
            unboxing islemi yapmak zorundayiz. 
            Dezavantasi: veriler uzerinde gezerken unboxing  işlemi yapmak zorundayiz.
            Buda performan kaybina neden olur.
             */

            #region Ornek 1
            int toplam = 0, sayi;
            ArrayList cuval = new ArrayList();
            cuval.Add(45);
            cuval.Add("Ali Veli");
            cuval.Add(DateTime.Now);
            cuval.Add(12.5f);
            cuval.Add(true);
            cuval.Add(5);
            cuval.Add(10);

            var ali = cuval[1];

            foreach (var item in cuval)
            {
                //if (int.TryParse(item.ToString(), out sayi))
                //    toplam += (int)item;


            }
            Console.WriteLine("Toplam:" + toplam);
            #endregion

            //for (int i = 0; i < 100; i++)
            //{
            //    cuval.Add(i);
            //}

            //foreach (var item in cuval)
            //{

            //    toplam += (int)item;
            //}
            Console.WriteLine("Toplam:" + toplam);
        }
    }
}