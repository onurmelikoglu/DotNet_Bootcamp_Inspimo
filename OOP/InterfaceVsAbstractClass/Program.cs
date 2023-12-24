namespace InterfaceVsAbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetinselOgrenciDosya dosya = new MetinselOgrenciDosya()
            {
                // DosyaYolu = "E:\\Development\\GitRepo\\DotNet_Bootcamp_Inspimo\\OOP\\InterfaceVsAbstractClass\\Dosyalar"
                DosyaYolu = "../../../Dosyalar/Ogrenciler.txt"
            };

            Console.WriteLine("Öğrenciler:\n" + dosya.OgrencileriGetir(true));

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
            Console.WriteLine("Ogrenciler:\n" + dosya.OgrencileriGetir(true));

            Console.WriteLine("Dosya Adı: " + dosya.DosyaAdiGetir());
            Console.WriteLine("Dosya Adı: " + dosya.DosyaUzantisiGetir());
        }
    }
}
