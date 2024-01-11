
using OgrenciYonetimApp.Entities;

namespace OgrenciYonetimApp.Data
{
    public static class Veriler
    {
        public static int EnSonId { get; set; } = 1;
        public static List<Ogrenci> Ogrenciler { get; set; }
        public static List<Sinif> Siniflar { get; set; }

        static Veriler()
        {
            Siniflar = new List<Sinif>()
            {
                new Sinif(EnSonId++, "1. Sınıf"),
                new Sinif(EnSonId++, "2. Sınıf"),
                new Sinif(EnSonId++, "3. Sınıf"),
                new Sinif(EnSonId++, "4. Sınıf"),
            };

            Ogrenciler = new List<Ogrenci>();

            Ogrenci ogrenci = new Ogrenci()
            {
                Id = EnSonId++,
                Adi = "Haluk Bilginer",
                Yasi = 18,
                MezunMu = false,
                Sinifi = Siniflar[0]
            };
            Ogrenciler.Add(ogrenci);

            ogrenci = new Ogrenci()
            {
                Id = EnSonId++,
                Adi = "Nejat İşler",
                Yasi = 35,
                MezunMu = true,
                Sinifi = Siniflar[3]
            };
            Ogrenciler.Add(ogrenci);

            ogrenci = new Ogrenci()
            {
                Id = EnSonId++,
                Adi = "Mehmet Ali Erbil",
                Yasi = 23,
                MezunMu = false,
                Sinifi = Siniflar[2]
            };
            Ogrenciler.Add(ogrenci);

            ogrenci = new Ogrenci()
            {
                Id = EnSonId++,
                Adi = "Kıvanç Tatlıtuğ",
                Yasi = 25,
                MezunMu = false,
                Sinifi = Siniflar[1]
            };
            Ogrenciler.Add(ogrenci);

            ogrenci = new Ogrenci()
            {
                Id = EnSonId++,
                Adi = "Acun Ilıcalı",
                Yasi = 28,
                MezunMu = true,
                Sinifi = Siniflar[3]
            };
            Ogrenciler.Add(ogrenci);
        }
    }
}
