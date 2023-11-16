namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayHello();

            Sum(6,4);

            int no1 = 5;
            int no2 = 7;

            Sum(no1, no2);

            double pi = GetPi();

            Console.WriteLine(pi);

            Console.WriteLine(Subtract(10, 5)); // 5

            string sonuc = KurumaGoreCalisanGetir("Onur", "Melikoğlu", "Apple");

            Console.WriteLine(sonuc);

            Console.WriteLine(DepartmanaGoreCalisanGetir("Leo","Alsaç","İstanbul Eğitim Akademisi"));
        }


        static void DisplayHello()
        {
            Console.WriteLine("Hello");
        }

        static void Sum(int no1, int no2)
        {
            int sum = no1 + no2;
            Console.WriteLine($"{no1} + {no2} = {sum}");
        }

        static double GetPi()
        {
            return 3.14;
        }

        static long Subtract(int number1, short number2)
        {
            return number1 - number2;
        }

        static string KurumaGoreCalisanGetir(string adi, string soyad, string kurum = "Microsoft")
        {
            string sonuc = adi + " " + soyad + " " + kurum + " kurumunda çalışıyor.";
            return sonuc;
        }

        static string DepartmanaGoreCalisanGetir(string ad, string soyad, string kurum = "Microsoft", string departman = "Eğitim")
        {
            return ad + " " + soyad + " " + " isimli çalışan " + kurum + " kurumnda" + " departmanında çalışıyor."; 
        }



    }
}