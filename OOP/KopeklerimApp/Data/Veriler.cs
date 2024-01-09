
using KopeklerimApp.Entities;
using System.Globalization;

namespace KopeklerimApp.Data
{
    public static class Veriler
    {
        public static int EnSonId { get; set; } = 1;
        public static List<Kopek> Kopekler { get; set; }
        public static List<Irk> Irklar { get; set; }

        static Veriler()
        {
            Irklar = new List<Irk>()
            {
                new Irk("İrlanda Seteri", Ulkeler.İrlanda, EnSonId++),
                new Irk("Shetland Sheepdog", Ulkeler.İskoçya, EnSonId++),
            };

            Kopekler = new List<Kopek>();
            
            Kopek kopek = new Kopek(EnSonId++)
            {
                Adi = "Angel",
                DogumTarihi = DateTime.Parse("01.06.1994", new CultureInfo("tr-TR")),
                Irki = Irklar[0] // Irklar.FirstOrDefault()
            };

            kopek = new Kopek(EnSonId++);
            kopek.Adi = "Leo";
            kopek.DogumTarihi = new DateTime(2014, 5, 11, 22, 43, 0);
            kopek.ErkekMi = true;
            kopek.Irki = Irklar[1]; // Irklar.LastOrDefault()
            Kopekler.Add(kopek);

            kopek = new Kopek(EnSonId++);
            kopek.Adi = "Angel";
            kopek.DogumTarihi = new DateTime(2012, 5, 11, 22, 43, 0);
            kopek.ErkekMi = false;
            kopek.Irki = Irklar[0]; // Irklar.LastOrDefault()
            Kopekler.Add(kopek);
        }
    }
}
