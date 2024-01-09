using TasKagitMakas.Models;
using TasKagitMakas.Models.Bases;
using TasKagitMakas.Services;
using TasKagitMakas.Services.Bases;

namespace TasKagitMakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OyuncuBase oyuncu = OyuncuOlustur();
            ITasKagitMakasService service = new TasKagitMakasService(oyuncu);
            char hareket = MenuGetir();
            while(hareket != 'ç')
            {
                if(!(hareket == 't' || hareket == 'k' || hareket == 'm' || hareket == 'y'))
                {
                    Console.WriteLine("\nGeçersiz Hareket");
                }
                else
                {
                    if(hareket == 'y')
                    {
                        service.YeniOyunaBasla();
                        Console.WriteLine("\nYeni Oyuna başlandı");
                    }
                    else
                    {
                        Console.WriteLine(service.Oyna(hareket));
                    }
                }
                hareket = MenuGetir();
            }
        }

        static OyuncuBase OyuncuOlustur()
        {
            OyuncuBase oyuncu;
            Console.Write("Rumuz: ");
            string rumuz = Console.ReadLine();
            oyuncu = new Oyuncu()
            {
                Rumuzu = rumuz
            };
            return oyuncu;
        }

        static char MenuGetir()
        {
            Console.WriteLine("Hareket: (t: taş, k: kağıt, m: makas, çÇ çıkış, y: yeni oyun): ");
            return Console.ReadLine().ToLower()[0];
        }
    }
}
