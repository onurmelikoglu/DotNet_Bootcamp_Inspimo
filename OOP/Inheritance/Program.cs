namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FutbolTakimi futbolTakimi1 = new FutbolTakimi()
            {
                Adi = "Fenerbahçe", // Takim base class'ından miras alınan özellik
                KurulusYili = 1907, // Takim base class'ından miras alınan özellik
                Sehir = "İstanbul", // Takim base class'ından miras alınan özellik

                TeknikDirektorAdi = "Jorge Jesus", // FutbolTakimi class'ı özelliği
                KaleciAdi = "Altay Bayındır", // FutbolTakimi class'ı özelliği
                DefansOyuncuAdlari = "Serdar Aziz, Gustavo Henrique, Attila Szalai, Ferdi Kadioglu", // FutbolTakimi class'ı özelliği
                OrtaSahaOyuncuAdlari = "Bright Osavi-Samuel, Miguel Crespo, Willian Arao", // FutbolTakimi class'ı özelliği
                ForvetOyuncuAdlari = "Diego Rossi, Joshua King, Michy Batshuayi", // FutbolTakimi class'ı özelliği
                OyunSistemi = "4-3-3" // FutbolTakimi class'ı özelliği
            };

            Console.WriteLine(futbolTakimi1.BilgiGetir()); // Takim base class'ından miras alınan davranış

            Console.WriteLine(futbolTakimi1.KadroGetir()); // FutbolTakimi class'ı davranışı

            Console.WriteLine("Oyun Sistemi: " + futbolTakimi1.OyunSistemi); // FutbolTakimi class'ı özelliği

            Console.WriteLine("Şehir: " + futbolTakimi1.Sehir); // Takim base class'ından miras alınan özellik

            // hem referans değişkeninin hem de oluşturulan objenin tipleri aynı olduğu için obje üzerinden tüm alan, özellik veya davranışlara ulaşılabilir

            Console.WriteLine();
        }
    }
}
