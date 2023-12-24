namespace AbstractClassesDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YazilimDersi yazilim = new YazilimDersi();
            yazilim.Id = 101;
            yazilim.Adi = "C# Programlama Dili";
            yazilim.Sinav1Notu = 90;
            yazilim.Sinav2Notu = 70;
            yazilim.SonSinavNotu = 80;

            string yazilimKodu = yazilim.KodGetir();
            double yazilimMaxNotu = yazilim.MaksimumNotGetir();
            double yazilimNotu = yazilim.DersNotuHesapla();

            Console.WriteLine($"Kodu: {yazilimKodu}");
            Console.WriteLine($"Adı: {yazilim.Adi}");
            Console.WriteLine($"Notu: {yazilimNotu} / {yazilimMaxNotu}");

            Console.WriteLine();

            MuzikDersi muzik = new MuzikDersi()
            {
                Adi = "Armoni",
                Id = 201,
                Sinav1Notu = 3,
                Sinav2Notu = 7
            };

            Console.WriteLine($"Kodu: {muzik.KodGetir()}");
            Console.WriteLine($"Adı: {muzik.Adi}");
            Console.WriteLine($"Notu: {muzik.DersNotuHesapla()} / {muzik.MaksimumNotGetir()}");

        }
    }
}
