using System;
using System.Collections.Generic;
using System.Text;

namespace Ortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1. Notu Giriniz.");
                int not1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Notu Giriniz.");
                int not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Notu Giriniz.");
                int not3 = Convert.ToInt32(Console.ReadLine());
            int ort = (not1 + not2 + not3) / 3;
            if(ort>80 && ort <= 100)
            {
                Console.WriteLine("A+ İle Geçtiniz Tebrikler.");
            }
            else if(ort>60 && ort <= 80)
            {
                Console.WriteLine("A iLE Geçtiniz.");
            }
            else if(ort<=60 && ort > 40)
            {
                Console.WriteLine("B+ İle Geçtiniz.");
            }
            else
            {
                Console.WriteLine("F İle Kaldınız");
            }
            Console.ReadLine();
        }
    }
}
