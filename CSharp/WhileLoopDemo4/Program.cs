namespace WhileLoopDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi,ortalama = 0;
            double toplam = 0;
            int sayiAdedi = 0;

            Console.WriteLine("Pozitif sayıların aritmetik ortalama hesaplaması: ");
            Console.Write($"{sayiAdedi + 1}. Sayı: (-1:çıkış) ");
            sayi = Convert.ToDouble(Console.ReadLine());
            while (sayi != -1)
            {
                toplam += sayi;
                sayiAdedi++;
                ortalama = toplam / sayiAdedi;
                Console.Write($"{sayiAdedi + 1}. Sayı: (-1:çıkış) ");
                sayi = Convert.ToDouble(Console.ReadLine());

            }

            Console.WriteLine("Ortalama: " + ortalama);


        }
    }
}
