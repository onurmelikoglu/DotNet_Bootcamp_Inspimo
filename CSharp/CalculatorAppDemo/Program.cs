using System.Collections;

namespace CalculatorAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hesap makinesi 4 işlem için
            // kullanıcıdan 1. sayı alınsın
            // kullanıcıdan işlem alınsın (+, -, /, *)
            // kullanıcıdan 2. sayı alınsın
            // sonuc sayisi = Hesapla(sayi1, sayi2, islem)
            // konsola sonuc sayisi yazdırılsın
            // debug işlemi Main methodunun içerisinde f10 ile girin

            //Console.Write("Bir Sayı Giriniz: ");
            //decimal sayi1 = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Lütfen bir işlem seçiniz: ( toplama: +, çıkarma: -, çarpma: *, bölme: / ) ");
            //string islem = Console.ReadLine();
            //Console.Write("2. Sayıyı Giriniz: ");
            //decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            string[] islemler = Operasyon();

            decimal sayi1 = Convert.ToDecimal(islemler[0]);
            string islem = islemler[1];
            decimal sayi2 = Convert.ToDecimal(islemler[2]);

            decimal sonuc = Hesapla(sayi1, sayi2, islem);
            Console.WriteLine($"İşlem Sonucu: {sonuc}");


        }

        static string[] Operasyon()
        {
            Console.Write("Bir Sayı Giriniz: ");
            string sayi1 = Console.ReadLine();
            Console.Write("Lütfen bir işlem seçiniz: ( toplama: +, çıkarma: -, çarpma: *, bölme: / ) ");
            string islem = Console.ReadLine();
            Console.Write("2. Sayıyı Giriniz: ");
            string sayi2 = Console.ReadLine();

            if (islem == "+" || islem == "-" || islem == "*" || islem == "/")
            {
                string[] islemler = { sayi1, islem, sayi2 };
                return islemler;
            }
            else
            {
                Console.WriteLine("Yanlış operatör seçtiniz lütfen tekrar deneyiz");
                Console.WriteLine("-----------------------------------------------");
                return Operasyon();
            }

                
        }

        static decimal Hesapla(decimal sayi1, decimal sayi2, string? islem)
        {
            if(islem == "+")
            {
                return sayi1 + sayi2;
            }
            else if(islem == "-")
            {
                return sayi1 - sayi2;
            }
            else if(islem == "*")
            {
                return sayi1 * sayi2;
            }
            else
            {
                return sayi1 / sayi2;
            }
            
        }
    }
}
