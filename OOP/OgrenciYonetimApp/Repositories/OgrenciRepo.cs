
using OgrenciYonetimApp.Data;
using OgrenciYonetimApp.Entities;
using OgrenciYonetimApp.Entities.Bases;
using OgrenciYonetimApp.Repositories.Bases;

namespace OgrenciYonetimApp.Repositories
{
    public class OgrenciRepo : IRepo
    {

        private SinifRepo sinifRepo = new SinifRepo();
        public string OgrenciEkle(string adi, int yasi, bool mezunMu, int sinifId)
        {
            if (OgrenciGetir(adi) is not null)
                return "Girilen ada sahip Öğrenci bulunmaktadır!";
            Kayit sinif = sinifRepo.KayitGetir(sinifId);
            if (sinif is null)
                return "Kayıt bulunamadı";
            Ogrenci ogrenci = new Ogrenci()
            {
                Id = Veriler.EnSonId++,
                Adi = adi.Trim(),
                Yasi = yasi,
                MezunMu = mezunMu,
                Sinifi = sinif as Sinif
            };
            Veriler.Ogrenciler.Add(ogrenci);
            return "İşlem başarılı";
        }

        private Ogrenci OgrenciGetir(string adi, int id = 0)
        {
            Ogrenci ogrenci = null;
            List<Ogrenci> mevcutOgrenciler = OgrencileriGetir();
            foreach (Ogrenci mevcutOgrenci in mevcutOgrenciler)
            {
                if (id == 0 && mevcutOgrenci.Adi.Equals(adi, StringComparison.OrdinalIgnoreCase))
                {
                    ogrenci = mevcutOgrenci;
                    break;
                }
                else if (id != mevcutOgrenci.Id && mevcutOgrenci.Adi.Equals(adi, StringComparison.OrdinalIgnoreCase))
                {
                    ogrenci = mevcutOgrenci;
                    break;
                }
            }
            return ogrenci;
        }

        public Kayit KayitGetir(int id)
        {
            Kayit kayit = null;
            List<Ogrenci> ogrenciler = OgrencileriGetir();
            foreach (Ogrenci ogrenci in ogrenciler)
            {
                if (ogrenci.Id == id)
                {
                    kayit = ogrenci;
                    break;
                }
            }
            return kayit;
        }

        public List<Ogrenci> OgrencileriGetir()
        {
            return Veriler.Ogrenciler;
        }

        public List<Ogrenci> OgrencileriGetir(string ad)
        {
            List<Ogrenci> ogrenciler = OgrencileriGetir();
            return ogrenciler
                .Where(ogrenci => ogrenci.Adi.Contains(ad.Trim(), StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Ogrenci> OgrencileriGetir(int id)
        {
            List<Ogrenci> ogrenciler = OgrencileriGetir();
            return ogrenciler.Where(ogrenci => ogrenci.Id == id).ToList();
        }

    }
}
