namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tam Sayı: ");
            int sayi = int.Parse(Console.ReadLine());
            if(sayi > 0)
            {
                Console.WriteLine("pozitif");
            }
            else if(sayi < 0)
            {
                Console.WriteLine("negatif");
            }
            else { Console.WriteLine("nötr"); }

            Console.WriteLine(sayi > 0 ? "pozitif" : sayi < 0 ? "negatif" : "nötr");

            string tekCiftSonuc = sayi % 2 == 0 ? "çift" : "tek";
            Console.WriteLine($"sayı {tekCiftSonuc}");


        }
    }
}