using System.Globalization;

namespace MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            int mutlakDeger = Math.Abs(sayi1 - sayi2);
            Console.WriteLine("sayi1 - sayi2 = " + (sayi1 - sayi2) + ", mutlak deger: " + mutlakDeger);

            Console.WriteLine($"Büyük: {Math.Max(sayi1,sayi2)}, Küçük: {Math.Min(sayi1,sayi2)}");

            int us = 2;
            Console.WriteLine($"sayi1 karesi: {sayi1 * sayi1}, {Math.Pow(sayi1,us)}");

            int sayi4 = 16;
            Console.WriteLine("sayi4 kare kökü: " + Math.Sqrt(sayi4)); // 4

            Console.WriteLine("8 küp kökü: " + Math.Pow(8, 1.0 / 3.0) );

            double sayi5 = 12.345;
            double sayi6 = 98.765;

            Console.WriteLine("taban: " + Math.Floor(sayi5) ); // 12
            Console.WriteLine("taban: " + Math.Ceiling(sayi5) ); // 13

            Console.WriteLine("taban: " + Math.Ceiling(sayi6) ); // 98
            Console.WriteLine("taban: " + Math.Ceiling(sayi6) ); // 99

            Console.WriteLine("Yuvarlama: " + Math.Round(sayi5) ); // 12
            Console.WriteLine("Yuvarlama: " + Math.Round(sayi6) ); // 99

            Console.WriteLine("1 haneye göre yuvarlama: " + Math.Round(sayi5, 1) ); // 12.3
            Console.WriteLine("1 haneye göre yuvarlama: " + Math.Round(sayi6, 1) ); // 98.8

            Console.WriteLine("2 haneye göre yuvarlama: " + Math.Round(sayi5, 2) ); // 12.34
            Console.WriteLine("2 haneye göre yuvarlama: " + Math.Round(sayi6, 2) ); // 98.76


            double yariCap, sonuc;
            string hesaplama, piGercekMi;

            Console.Write("Yarıçap (0: çıkış)");
            yariCap = Convert.ToDouble(Console.ReadLine(), new CultureInfo("tr-TR"));
            while( yariCap != 0)
            {
                Console.Write("Hesaplama (a: alan, ç: çevre): ");
                hesaplama = Console.ReadLine();
                Console.Write("Pİ gerçek değeri mi? (e:evet, h:hayır): ");
                piGercekMi = Console.ReadLine();
                sonuc = Hesaplama(yariCap, hesaplama, piGercekMi);
                Console.WriteLine((hesaplama == "a" ? "Alan" : "Çevre") + sonuc);
            }

            for(decimal i = 1.0m; i <= 1.9m; i += 0.1m)
            {
                if(i == 2.5m)
                {
                    Console.WriteLine("2.5 için yuvarlama: " + Math.Round(i) );
                }
                else
                {
                    Console.WriteLine("Yuvarlama: " + Math.Round(i) );
                }
            }

            decimal dno1 = 1.1m;
            decimal dno2 = dno1 + 0.1m; // 1,2
            if(dno2 == 1.2m)
            {
                Console.WriteLine("eşit");
            }
            else
            {
                Console.WriteLine("eşit değil");
            }
       

        }

        static double Hesaplama(double yariCap, string hesaplama, string piGercekMi)
        {
            double sonuc;
            double pi = piGercekMi == "e" ? Math.PI : 3.14;
            if(hesaplama == "a")
            {
                sonuc = pi * Math.Pow(yariCap, 2);
            }
            else
            {
                sonuc = 2 * pi * yariCap;
            }
            return sonuc;
        }
    }
}
