using System;
using System.Collections.Generic;

namespace _18_KodUretim
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string kasa = "Kasa-001";
                Console.WriteLine("Kodu Giriniz");
                kasa = Console.ReadLine();
                Console.WriteLine(CreateNewKod(kasa));

            }

            //var array = kasa.ToCharArray();
            //List<string> nums = new List<string>();
            //foreach (var item in array)
            //{
            //    if (Char.IsDigit(item))
            //    {
            //        nums.Add(Char.GetNumericValue(item).ToString());
            //    }

            //}
            //int sayi1=nums.last



            //if (nums[2]<9)
            //{
            //    nums[2] += 1;
            //}
            //else
            //{
            //    nums[2] = 0;
            //    if (nums[1] < 9)
            //    {
            //        nums[1] += 1;
            //    }
            //    else
            //    {
            //        nums[1] = 0;
            //        nums[0] += 1;
            //    }

            //}
            //string sondurum = "Kasa-";
            //foreach (var item in nums)
            //{
            //    sondurum += item.ToString();
            //}
            //Console.WriteLine(sondurum);
        }

        private static string CreateNewKod(string code)
        {
            //Kasa-001
            string number = "";
            foreach (var item in code)
            {
                if (char.IsDigit(item))
                    number += item; //999=>1000
                else
                    number = "";
            }
            var newNumber = number == "" ? "1" : (long.Parse(number) + 1).ToString();
            //Gelen kod ile yeni olusturulan kodun farkini al
            var fark = code.Length - newNumber.Length;
            if (fark < 0)
                fark = 0;

            string newcode = code.Substring(0, fark);
            newcode += newNumber;
            return newcode;

        }
    }
}
