using BarbutDemo.Models;

namespace BarbutDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BarbutDemo.Models.Zar zar
            Zar zar = new Zar();
            int sayi1, sayi2;
            Console.Write("Oynamak istermisin? (e: evet, h: hayır)");
            string cevap = Console.ReadLine();
            while (cevap != "h")
            {
                sayi1 = zar.At();
                sayi2 = zar.At();
                if(sayi1 > sayi2)
                {
                    Console.WriteLine($"1. zar kazandı. (1.zar: {sayi1}, 2.zar: {sayi2})");
                }else if (sayi1 < sayi2)
                {
                    Console.WriteLine($"2. zar kazandı. (1.zar: {sayi1}, 2.zar: {sayi2})");
                }
                else
                {
                    Console.WriteLine($"Berabere (1.zar: {sayi1}, 2.zar: {sayi2})");
                }
                Console.Write("Oynamak istermisin? (e: evet, h: hayır)");
                cevap = Console.ReadLine();
            }
        }
    }
}
