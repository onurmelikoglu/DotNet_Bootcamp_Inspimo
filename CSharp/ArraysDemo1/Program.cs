namespace ArraysDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adet: ");
            int adet = int.Parse(Console.ReadLine());
            int sayi;
            int[] sayilar = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                Console.Write($"{i+1}. sayı: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
            }

            Console.WriteLine("En büyük: " + EnBuyukVeyaEnKucukBul1(sayilar));
            Console.WriteLine("En küçük: " + EnBuyukVeyaEnKucukBul1(sayilar,false));

            Console.WriteLine("En büyük: " + EnBuyukVeyaEnKucukBul1(sayilar));
            Console.WriteLine("En küçük: " + EnBuyukVeyaEnKucukBul1(sayilar, false));


        }

        static  int EnBuyukVeyaEnKucukBul1(int[] sayilar, bool enBuyukMu = true)
        {
            int sonuc = sayilar[0];
            for(int i = 1; i < sayilar.Length; i++)
            {
                if (enBuyukMu && sayilar[i] > sonuc) 
                {
                    sonuc = sayilar[i];
                }
                else if (!enBuyukMu && sayilar[i] < sonuc)
                {
                    sonuc = sayilar[i];
                }
            }
            return sonuc;
        }

        static int EnBuyukVeyaEnKucukBul2(int[] sayilar, bool enBuyukMu = true)
        {
            return enBuyukMu ? sayilar.Max() : sayilar.Min();
        }
    }
}
