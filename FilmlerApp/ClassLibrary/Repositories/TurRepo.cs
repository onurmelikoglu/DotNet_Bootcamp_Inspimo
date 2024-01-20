using ClassLibrary.Data;
using ClassLibrary.Entities;
using ClassLibrary.Entities.Bases;
using ClassLibrary.Repositories.Bases;

namespace ClassLibrary.Repositories
{
    public class TurRepo : IRepo
    {
        public List<Tur> TurleriGetir()
        {
            List<Tur> turler = new List<Tur>();
            List<Kayit> mevcutKayitlar = KayitlariGetir();
            foreach (Kayit mevcutKayit in mevcutKayitlar)
            {
                if (mevcutKayit is Tur)
                {
                    turler.Add(mevcutKayit as Tur);
                }
            }
            return turler;
        }
        public Kayit KayitGetir(int id)
        {
            Tur tur = null;
            List<Tur> turler = TurleriGetir();
            foreach(Tur t  in turler)
            {
                if(t.Id == id)
                {
                    tur = t; break;
                }
            }

            return tur;
        }

        public List<Tur> TurleriGetir(List<int> turIdleri)
        {
            List<Tur> turler = new List<Tur>();
            List<Tur> mevcutTurler = TurleriGetir();
       
            foreach(int turId in turIdleri)
            {
                foreach(Tur mevcutTur in mevcutTurler)
                {
                    if(mevcutTur.Id == turId)
                    {
                        turler.Add(mevcutTur); break;
                    }
                }
            }

            return turler;
        }

        public List<Kayit> KayitlariGetir()
        {
            List<Kayit> kayitlar = new List<Kayit>();
            List<Tur> mevcutTurler = Veriler.Turler;
            foreach(Tur mevcutTur in mevcutTurler)
            {
                kayitlar.Add(mevcutTur);
            }
            return kayitlar;
        }
    }
}
