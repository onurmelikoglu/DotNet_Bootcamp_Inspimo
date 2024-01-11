
using OgrenciYonetimApp.Data;
using OgrenciYonetimApp.Entities;
using OgrenciYonetimApp.Entities.Bases;

namespace OgrenciYonetimApp.Repositories
{
    public class SinifRepo
    {
        public List<Sinif> SiniflariGetir()
        {
            return Veriler.Siniflar;
        }

        public Kayit KayitGetir(int id)
        {
            Kayit kayit = null;
            List<Sinif> siniflar = SiniflariGetir();
            foreach (Sinif sinif in siniflar)
            {
                if (sinif.Id == id)
                {
                    kayit = sinif;
                    break;
                }
            }
            return kayit;
        }

    }
}
