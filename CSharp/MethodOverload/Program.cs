namespace MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = Topla((int)1.2, (int)2.3);
            Console.WriteLine(toplam);

            int n1 = 10;
            int n2 = 20;
            double sum = Topla(n1, n2);
            Console.WriteLine(sum); // 30

            Console.WriteLine(Topla(100,200,300));

            sum = Topla(30, 40, 50, 60, 70, 80);

            Console.WriteLine(sum);

            ToplaVeYazdir("Sayıların Toplamı", 1, 3, 5, 7, 9);

        }

        static int Topla(int sayi1,  int sayi2)
        {
            return sayi1 + sayi2;
        }

        static double DoubleToplam(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }

        static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        static int Topla(params int[] sayilar)
        {
            return sayilar.Sum();
        }

        static void ToplaVeYazdir(string message, params int[] sayilar)
        {
            Console.WriteLine($"{message}: {sayilar.Sum()}");
        }
        

    }
}