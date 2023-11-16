namespace TernaryOperatorDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yazı mı (y) Tura mı (t) ?");
            string giris = Console.ReadLine();
            Oyna1(giris);

        }

        static void Oyna1(string giris)
        {
            if (giris == "y" || giris == "Y" || giris == "t" || giris == "T")
            {
                string yuz = "y";
                if (giris == "yuz")
                {
                    Console.WriteLine("Tebrikler bildiniz.");
                }
                else
                {
                    Console.WriteLine("Üzgünüm Bilemediniz.");
                }
            }
            else
            {
                Console.WriteLine("Yazı için (y), tura içinse (t) girilmelidir");
            }
            
            
        }

        static void Oyna2(string giris)
        {
            if (giris == "y" || giris == "Y" || giris == "t" || giris == "T")
            {
                int girisSayisi = giris == "y" || giris == "Y" ? 2 : 1;
                Random rastgele = new Random();
                int rastgeleSayi = rastgele.Next(1,3); // 1 (t) veya 2 (y)

                if (rastgeleSayi == girisSayisi)
                {
                    Console.WriteLine("Tebrikler bildiniz.");
                }
                else
                {
                    Console.WriteLine("Üzgünüm Bilemediniz.");
                }
            }
            else
            {
                Console.WriteLine("Yazı için (y), tura içinse (t) girilmelidir");
            }


        }
    }
}