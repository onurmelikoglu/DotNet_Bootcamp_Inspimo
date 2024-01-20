
using ClassLibrary.Data;
using ClassLibrary.Entities;
using ClassLibrary.Entities.Bases;
using ClassLibrary.Repositories.Bases;

namespace ClassLibrary.Repositories
{
    public class YonetmenRepo : IRepo
    {
        public List<Yonetmen> YonetmenleriGetir()
        {
            List<Yonetmen> yonetmenler = new List<Yonetmen>();
            List<Kayit> mevcutKayitlar = KayitlariGetir();
            foreach(Kayit mevcutKayit in mevcutKayitlar) 
            {
                if(mevcutKayit is Yonetmen)
                {
                    yonetmenler.Add(mevcutKayit as Yonetmen);
                }
            }
            return yonetmenler;
        }
        public Kayit KayitGetir(int id)
        {
            Yonetmen yonetmen = null;
            var yonetmenler = YonetmenleriGetir();
            foreach(var y in yonetmenler)
            {
                if(y.Id == id)
                {
                    yonetmen = y; break;
                }
            }
            return yonetmen;
        }

        public List<Kayit> KayitlariGetir()
        {
            List<Kayit> kayitlar = new List<Kayit>();
            List<Yonetmen> mevcutYonetmenler = Veriler.Yonetmenler;
            foreach(Yonetmen mevcutYonetmen in mevcutYonetmenler)
            {
                kayitlar.Add(mevcutYonetmen);
            }
            return kayitlar;
        }
    }
}
