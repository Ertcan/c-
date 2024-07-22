using System;
using System.Collections.Generic;
using System.Text;

namespace MiniAtm
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz : \n 1 => Bakiye Görüntüle. \n 2 => Para Çekme. \n 3 => Para Yatırma. \n q => çıkış. ");
                string sec = Console.ReadLine();
                if(sec == "1")
                {
                    Console.WriteLine("Mevcut Bakiyeniz => " + bakiye);
                }
                else if(sec == "2")
                {
                    Console.WriteLine("Ne Kadar Para Çekmek İstiyorsunuz ?");
                    int cek = Convert.ToInt32(Console.ReadLine());
                    if(cek> bakiye)
                    {
                        Console.WriteLine("Yetersiz bakiye!");
                    }
                    else
                    {
                        bakiye = bakiye - cek;
                        Console.WriteLine("İşlem Başarılı !");
                    }
                }
                else if(sec == "3")
                {
                    Console.WriteLine("Ne kadar para yatırmak istiyorsunuz ?");
                    int yat = Convert.ToInt32(Console.ReadLine());
                    bakiye = bakiye + yat;
                    Console.WriteLine("İşlem Başarılı !");
                }
                else if(sec == "q")
                {
                    Console.WriteLine("Çıkış Yapılıyor...");
                    break;
                }
                else {
                    Console.WriteLine("Hatalı Giriş Tekrar deneyin !");
                }
            }
            Console.ReadLine();
        }
    }
}
