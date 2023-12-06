namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas1 = new Vatandas();
            Console.WriteLine(vatandas1.Ulke);
            Console.WriteLine(vatandas1.Sehir);

            Vatandas vatandas2 = new Vatandas()
            {
                Ulke = "ABD",
                Sehir = "New York",
                Adi = "Onur",
                Soyadi = "Melikoğlu"
            };

            Console.WriteLine(vatandas2.AdSoyadGetir() + "\n" + vatandas2.UlkeVeSehirGetir());

            Ogrenci ogrenci1 = new Ogrenci()
            {
                Adi = "Çağıl",
                Soyadi = "Alsaç"
            };

            ogrenci1.OrtalamaHesaplama();
            Console.WriteLine( ogrenci1.Getir() );

            Ogrenci ogrenci2 = new Ogrenci("Luna", "Alsaç", 80, 70, 90);

            ogrenci2.OrtalamaHesaplama();
            Console.WriteLine(ogrenci2.Getir());

            Ogrenci ogrenci3 = new Ogrenci(10, 20, 30)
            {
                Adi = "Leo",
                Soyadi = "Jr."
            };

            ogrenci3.OrtalamaHesaplama();
            Console.WriteLine(ogrenci3.Getir());


        }
    }
}
