namespace WhileLoopDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal KDV = 0.18m;
            decimal ucret, toplam;

            Console.Write("Ücret (TL): ");
            string giris = Console.ReadLine();

            // Faktoriyel ve palindrome problemi ödev

            while (giris != "ç" && giris != "Ç")
            {
                ucret = Convert.ToDecimal(giris);
                toplam = ucret + ucret * KDV;
                Console.WriteLine($"Ücret: {ucret} TL");
                Console.WriteLine($"KDV: {KDV} TL");
                Console.WriteLine($"Toplam Ücret: {toplam} TL");
                Console.Write("Ücret (TL): ");
                giris = Console.ReadLine();
            }

        }
    }
}
