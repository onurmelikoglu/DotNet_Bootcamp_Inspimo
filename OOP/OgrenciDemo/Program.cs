using OgrenciDemo.Models;

namespace OgrenciDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci()
            {
                Adi = "Çağıl",
                Soyadi = "Alsaç",
                Vize1 = 10m,
                Vize2 = 20m,
                Final = 90m
            };
            Console.WriteLine("Adı: " + ogrenci1.Adi + " " + ogrenci1.Soyadi + "\n" + "Durum: " + ogrenci1.Durum + " (" + ogrenci1.Ortalama + ") ");
           

            Ogrenci ogrenci2 = new Ogrenci("Luna", "Alsac", 90m, 80m, 20m);

            Console.WriteLine("Adı: " + ogrenci2.Adi + " " + ogrenci2.Soyadi + "\n" + "Durum: " + ogrenci2.Durum + " (" + ogrenci2.Ortalama + ") ");
        }
    }
}
