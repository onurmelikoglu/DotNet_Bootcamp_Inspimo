using InterfaceVsAbstractClass1.Bases;

namespace InterfaceVsAbstractClass1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OgrenciDosyaBase dosya = new MetinselOgrenciDosya()
            {
                DosyaYolu = "../../../Dosyalar/Ogrenciler.txt"
            };

            Console.WriteLine(dosya.OgrencileriGetir(true));

            Console.WriteLine("Yeni Ogrenci");
            Console.Write("Adı: ");
            string adi = Console.ReadLine();
            Console.Write("Soyadı: ");
            string soyadi = Console.ReadLine();
            Console.Write("Yaşı: ");
            string yasi = Console.ReadLine();

            // Adı:Luna - Soyadı:Alsaç - Yaşı:1
            string yeniOgrenci = "Adı: " + adi + " - Soyadi: " + soyadi + " - Yaşı: " + yasi;
            dosya.OgrenciEkle(yeniOgrenci);

            Console.WriteLine(dosya.OgrencileriGetir(false));

            Console.WriteLine($"Dosya Adı: {dosya.DosyaAdiGetir()}");
            Console.WriteLine($"Dosya Uzantısı: {dosya.DosyaUzantisiGetir()}");

        }
    }
}
