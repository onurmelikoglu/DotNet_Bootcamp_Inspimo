using Polimorphism.Enums;
using Polimorphism.Models;
using Polimorphism.Models.Bases;
using System.Globalization;

namespace Polimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoOyunu oyun1 = new VideoOyunu()
            {
                Adi = "FTL",
                CikisTarihi = DateTime.Parse("24.12.2012", new CultureInfo("tr-TR")),
                Turleri = new string[]
                {
                    "Uzay","Turn Based Stratejisi"
                },
                OyuncuSayisi = OyuncuSayisi.TekOyuncu | OyuncuSayisi.ÇokOyuncu
            };

            Console.WriteLine($"Oyun Adı: {oyun1.Adi}");
            Console.WriteLine($"Çıkış Tarihi: {oyun1.CikisTarihi.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Türü: {oyun1.TurleriGosterim}");
            Console.WriteLine($"Oyuncu Sayısı: {oyun1.OyuncuSayisiGosterim}");

            oyun1 = new PcOyunu()
            {
                Adi = "Half Life 2",
                CikisTarihi = DateTime.Parse("23.03.2004", new CultureInfo("tr-TR")),
                OyuncuSayisi = OyuncuSayisi.TekOyuncu | OyuncuSayisi.ÇokOyuncu,
                Turleri = new string[] { "FPS", "Bilim Kurgu" },
                IsletimSistemleri = new string[] { "Windows98", "WindowsME", "Windows XP" },
                SteamOyunuMu = true
            };

            Console.WriteLine($"Oyun Adı: {oyun1.Adi}");
            Console.WriteLine($"Çıkış Tarihi: {oyun1.CikisTarihi.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Türü: {oyun1.TurleriGosterim}");
            Console.WriteLine($"Oyuncu Sayısı: {oyun1.OyuncuSayisiGosterim}");

            PcOyunu pcOyunu = oyun1 as PcOyunu;
            Console.WriteLine("İşletim Sİstemleri: " + pcOyunu.IsletimSistemleri);
            Console.WriteLine("Stema Oyunu Mu?" + pcOyunu.SteamOyunuMu);

            oyun1 = new PlaystationOyunu()
            {
                Adi = "Gran Turismo 7",
                CikisTarihi = new DateTime(2022, 3, 4),
                OyuncuSayisi = OyuncuSayisi.ÇokOyuncu,
                Turleri = new string[]
                {
                    "Yarış",
                    "Spor",
                    "Simülasyon"
                },
                Modelleri = new byte[] { 4, 5 }
            };

            Console.WriteLine($"Oyun Adı: {oyun1.Adi}");
            Console.WriteLine($"Çıkış Tarihi: {oyun1.CikisTarihi.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Türü: {oyun1.TurleriGosterim}");
            Console.WriteLine($"Oyuncu Sayısı: {oyun1.OyuncuSayisiGosterim}");

            PlaystationOyunu playstationOyunu = (PlaystationOyunu)oyun1;
            Console.WriteLine("Modelleri: " + string.Join(",", playstationOyunu.Modelleri));

        }
    }
}
