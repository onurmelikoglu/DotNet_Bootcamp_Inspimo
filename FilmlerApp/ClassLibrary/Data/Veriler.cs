
using ClassLibrary.Entities;
using System.Globalization;

namespace ClassLibrary.Data
{
    public static class Veriler
    {
        public static int EnSonId { get; set; } = 1;
        public static List<Film> Filmler { get; set; }
        public static List<Yonetmen> Yonetmenler { get; set; }
        public static List<Tur> Turler { get; set; }
        public static string KayitBulunamadiMesaji => "Kayit Bulunamadı";
        public static string HataMesaji => "İşlem Sırasında Hata Meydana Geldi";

        static Veriler()
        {
            Turler = new List<Tur>();
            Turler.Add(new Tur("Aksiyon", ++EnSonId));
            Turler.Add(new Tur("Bilim Kurgu", ++EnSonId));
            Turler.Add(new Tur("Suç", ++EnSonId));

            Yonetmenler = new List<Yonetmen>()
            {
                new Yonetmen()
                {
                    Id = ++EnSonId,
                    Adi = "James",
                    Soyadi = "Cameron"
                },
                new Yonetmen()
                {
                    Id = ++EnSonId,
                    Adi = "Guy",
                    Soyadi = "Ritchie"
                },
            };

            Filmler = new List<Film>();
            Film film = new Film()
            {
                Id = ++EnSonId,
                Adi = "Avatar",
                YapimYili = 2009,
                Gisesi = 10000000,
                GösterimTarihi = DateTime.Parse("18.12.2009", new CultureInfo("tr-TR")),
                Platform = Platform.Sinema
            };
            film.Yonetmeni = Yonetmenler.First();
            film.Turleri.Add(Turler[0]);
            film.Turleri.Add(Turler[1]);
            Filmler.Add(film);

            film = new Film()
            {
                Id = ++EnSonId,
                Adi = "Sherlock Holmes",
                YapimYili = 2009,
                Gisesi = 20000000,
                GösterimTarihi = DateTime.Parse("15.10.2010", new CultureInfo("tr-TR")),
                Platform = Platform.Sinema,
                Yonetmeni = Yonetmenler.Last(),
            };
            film.Turleri.Add(Turler[0]);
            film.Turleri.Add(Turler[2]);
            Filmler.Add(film);
       
        }

        public static string KayitSayisiMesajiGetir(int kayitSayisi)
        {
            return kayitSayisi == 0 ? KayitBulunamadiMesaji : kayitSayisi + " kayit bulundu.";
        }
    
    }
}
