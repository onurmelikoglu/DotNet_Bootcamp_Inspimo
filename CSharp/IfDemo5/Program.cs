namespace IfDemo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaslikYaz();
            double boy = GirisYap("Boy (m): ");
            double kilo = GirisYap("Kilo (m): ");
            double endeks = EndeksHesapla(boy, kilo);
            Console.WriteLine($"Endeks: {endeks}");
            HesapSonucunuYazdir(endeks);

        }

        static void HesapSonucunuYazdir(double endeks)
        {
            Console.Write("Vücut kütle endeksiniz: ");
            if(endeks < 10)
            {
                Console.WriteLine("Zayıf");
            }
            else if(endeks < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (endeks < 30)
            {
                Console.WriteLine("Kilolu");
            }
            else if (endeks < 35)
            {
                Console.WriteLine("Obez");
            }
            else
            {
                Console.WriteLine("Ultra Obez");
            }
        }

        static double EndeksHesapla(double boy, double kilo)
        {
            return kilo / (boy * boy);
        }

        static double GirisYap(string mesaj)
        {
            Console.Write(mesaj);
            return Convert.ToDouble(Console.ReadLine());
        }

        static void BaslikYaz()
        {
            Console.WriteLine("Vüzut Kütle Endekssi Hesaplama");
        }
    }
}