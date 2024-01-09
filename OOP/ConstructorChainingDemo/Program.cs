using ConstructorChainingDemo.Models;

namespace ConstructorChainingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OgrenciDosya dosya = new OgrenciDosya("../../../Dosyalar/ÖğrenciListesi.txt");

            var ogrenciler = dosya.OgrencileriGetir2();

            Console.WriteLine("Öğrenciler: ");
            foreach(var o1 in ogrenciler)
            {
                Console.WriteLine("Öğrenci adı: " + o1.Adi);
                Console.WriteLine("Öğrenci soyadı: " + o1.Soyadi);
                Console.WriteLine("Öğrenci yaşı: " + o1.Yasi);
            }

            Console.WriteLine("Yeni Öğrenci: ");
            Console.Write("Adı: ");
            string adi = Console.ReadLine();
            Console.Write("Soyadı: ");
            string soyad = Console.ReadLine();
            Console.Write("Yaşı: ");
            byte yasi = byte.Parse( Console.ReadLine() );

            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = adi,
                Soyadi = soyad,
                Yasi = yasi
            };

            dosya.OgrenciEkle(ogrenci);

            ogrenciler = dosya.OgrencileriGetir2();

            foreach ( var o2 in ogrenciler)
            {
                Console.WriteLine("Öğrenci adı: " + o2.Adi);
                Console.WriteLine("Öğrenci soyadı: " + o2.Soyadi);
                Console.WriteLine("Öğrenci yaşı: " + o2.Yasi);
            }
        }
    }
}
