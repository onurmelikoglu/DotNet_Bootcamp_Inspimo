using ClassLibrary.Data;
using ClassLibrary.Entities;
using ClassLibrary.Entities.Bases;
using ClassLibrary.Repositories.Bases;

namespace ClassLibrary.Repositories
{
    public class FilmRepo : IRepo
    {

        public List<Film> FilmleriGetir()
        {
            List<Film> filmler = new List<Film>();
            List<Kayit> mevcutKayitlar = KayitlariGetir();
            foreach(Kayit kayit in mevcutKayitlar)
            {
                if(kayit is Film)
                {
                    filmler.Add(kayit as Film);
                }
            }
            return filmler;
        }
        public Kayit KayitGetir(int id)
        {
            Film film = null;
            List<Film> mevcutFilmler = FilmleriGetir();
            foreach(Film mevcutFilm in mevcutFilmler)
            {
                if(mevcutFilm.Id == id)
                {
                    film = mevcutFilm; break;
                }
            }
            return film;
        }

        public List<Kayit> KayitlariGetir()
        {
            List<Kayit> kayitlar = new List<Kayit>();
            List<Film> mevutFilmler = Veriler.Filmler;
            foreach (Film mevcutFilm in mevutFilmler)
            {
                kayitlar.Add(mevcutFilm);
            }
            return kayitlar;
        }

        public string FilmEkle(Film film)
        {
            if(film.Turleri is null || film.Turleri.Count == 0)
            {
                return "Filmin türleri girilmemiştir";
            }
            Film mevcutFilm = FilmGetir(film.Adi);
            if(mevcutFilm is not null)
            {
                return "Girilen ada sahip film bulunmamaktadır!";
            }
            film.Id = ++Veriler.EnSonId;
            Veriler.Filmler.Add(film);
            return "Film Başarıyla Eklendi!";
        }

        public string FilmGuncelle(Film film)
        {
            if(film.Turleri is null || film.Turleri.Count == 0)
            {
                return "Filmin türleri girilmemiştir";
            }
            Film mevcutFilm = FilmGetir(film.Adi, film.Id);
            mevcutFilm = KayitGetir(film.Id) as Film;
            mevcutFilm.Adi = film.Adi.Trim();
            mevcutFilm.YapimYili = film.YapimYili;
            mevcutFilm.Gisesi = film.Gisesi;
            mevcutFilm.Yonetmeni = film.Yonetmeni;
            mevcutFilm.Turleri = film.Turleri;
            mevcutFilm.GösterimTarihi = film.GösterimTarihi;
            mevcutFilm.Platform = film.Platform;
            mevcutFilm.YerliMi = film.YerliMi;

            return "Güncelleme Başarılı";

        }

        private Film FilmGetir(string adi, int id = 0)
        {
            Film film = null;
            List<Film> mevcutFilmler = FilmleriGetir();
            foreach (Film mevcutFilm in mevcutFilmler)
            {
                if (id == 0 && mevcutFilm.Adi.Equals(film.Adi.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    film = mevcutFilm; break;
                }
                else if(id != mevcutFilm.Id && mevcutFilm.Adi.Equals(film.Adi.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    film = mevcutFilm; break;
                }
            }
            return film;
        }
    }
}
