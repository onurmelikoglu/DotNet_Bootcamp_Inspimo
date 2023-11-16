namespace IfDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı: ");

            // string giris = Console.ReadLine();
            // int sayi = Convert.ToInt32(giris);

            // int sayi = Convert.ToInt32(Console.ReadLine());
            int sayi = int.Parse(Console.ReadLine());

            if(sayi > 0)
            {
                Console.WriteLine("Pozitif");
            }
            else if(sayi < 0)
            {
                Console.WriteLine("Negatif");
            }
            else {
                Console.WriteLine("Nötr");
            }
        }
    }
}