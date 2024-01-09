
namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value Types
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 100;
            Console.WriteLine("Sayı 2: " + sayi2 + ", Sayı 1: " + sayi1);

            int sayi3 = 30;
            Guncelle(sayi3);
            Console.WriteLine($"Sayı 3: {sayi3}");
            #endregion

            #region Reference Types
            string[] sehirler1 = { "Ankara", "Adana", "Antalya" };
            string[] sehirler2 = { "Bursa", "Bolu", "Balıkesir" };
            Console.WriteLine("Şehirler1 0. index elemanı: " + sehirler1[0] + ", Şehirler2 0. index elemanı: " + sehirler2[0]);
            Console.WriteLine("Şehirler1 0. index elemanı: " + sehirler1[0] + ", Şehirler2 0. index elemanı: " + sehirler2[0]);
            Console.WriteLine("Şehirler1 0. index elemanı: " + sehirler1[0] + ", Şehirler2 0. index elemanı: " + sehirler2[0]);

            Sehir sehir1 = new Sehir("Zonguldak");
            Sehir sehir2 = new Sehir("Yalova");
            Console.WriteLine("Şehir1: " + sehir1.Adi + ", Şehir 2: " + sehir2.Adi);
            sehir1 = sehir2;
            Console.WriteLine("Şehir1: " + sehir1.Adi + ", Şehir 2: " + sehir2.Adi);
            sehir2.Adi = "İzmir";
            Console.WriteLine("Şehir1: " + sehir1.Adi + ", Şehir 2: " + sehir2.Adi);
            #endregion

            #region String
            string city1 = "Liberty City";

            #endregion
        }



        private static void Guncelle(int sayi3)
        {
            sayi3 = 300;
        }
    }

    class Sehir
    {
        public string Adi { get; set; }

        public Sehir(string adi)
        {
            Adi = adi;
        }
    }
}
