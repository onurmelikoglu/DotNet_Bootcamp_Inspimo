namespace PalindromeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Bir Kelime Giriniz: ");

            string giris = Console.ReadLine();
            bool palindromeMu = true;
            int girisUzunluk = giris.Length;

            for (int i = 0; i < girisUzunluk / 2; i++)
            {
                // Kelimenin ilk ve son harfinden başlayarak karşılaştırma yapar
                if (giris[i] != giris[girisUzunluk - i - 1])
                {
                    palindromeMu = false; break;
                }
            }

            if (palindromeMu)
            {
                Console.WriteLine($"{giris} kelimesi bir polindrome'dur");
            }
            else
            {
                Console.WriteLine($"{giris} kelimesi bir polindrome değildir");
            }
        }
    }
}
