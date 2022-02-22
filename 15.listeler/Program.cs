using System;
using System.Collections.Generic;

namespace _15_Listeler
{
    class Program
    {
        static void Main(string[] args)
        {
            // List => ArrayList'in tipi belli olan halidir
            // Gunluk hayatta yogun kullanilir

            List<int> sayilar = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(i);
            }
            //sayilar.Add("ali");
            //sayilar.Add(DateTime.Now);
            List<string> sehirler = new List<string>();

            sehirler.Add("Adana");
            sehirler.Add("Bolu");



            Console.WriteLine("Hello World!");
        }
    }
}