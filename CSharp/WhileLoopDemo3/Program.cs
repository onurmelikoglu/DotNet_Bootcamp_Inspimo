namespace WhileLoopDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ( 1 x 2 - 3 x 4 ) + ( 5 x 6 - 7 x 8 ) + .... ( 997 x 998 - 999 x 1000 )

            //Console.Write("Bir sayi giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            int sayi = 997;
            int toplam = 0;

          
            for (int i = 1; i <= sayi; i += 4)
            {
                int islem = i * (i + 1) - (i + 2) * (i + 3);
                toplam += islem;
            }

            Console.Write($"Sonuc: {toplam}");
        }
    }
}
