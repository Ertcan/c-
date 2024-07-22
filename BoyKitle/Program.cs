using System;
using System.Collections.Generic;
using System.Text;

namespace BoyKitle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Boyunuzu giriniz => ");
            double boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kütlenizi Giriniz => ");
            double kilo = Convert.ToDouble(Console.ReadLine());
            double endeks = kilo / (boy * boy);
            if (endeks <= 18)
            {
                Console.WriteLine("Endeksin => " + endeks + " Zayıfsın.");
            }
            else if(endeks> 18 && endeks <= 25)
            {
                Console.WriteLine("Endeksin => " + endeks + " Normalsin.");
            }
            else if(endeks> 25) 
            {
                Console.WriteLine("Endeksin => " + endeks + " Obezsin.");
            }
            else
            {
                Console.WriteLine("Bir Şeyler ters gitti.");
            }
            Console.ReadLine();
        }
    }
}
