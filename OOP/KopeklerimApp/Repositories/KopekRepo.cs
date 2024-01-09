
using KopeklerimApp.Data;
using KopeklerimApp.Entities;

namespace KopeklerimApp.Repositories
{
    public class KopekRepo
    {
        public List<Kopek> KopekleriGetir()
        {
            return Veriler.Kopekler;
        }

        public List<Kopek> KopekleriGetir(string adi)
        {
            List<Kopek> sonucKopekler = new List<Kopek>();
            List<Kopek> kopekler = KopekleriGetir();
            foreach(Kopek kopek in kopekler)
            {
                if (kopek.Adi.Contains(adi.Trim(), StringComparison.OrdinalIgnoreCase)){
                    sonucKopekler.Add(kopek);
                }
            }
            return sonucKopekler;
        }

        public Kopek KopekGetir(int id)
        {
            Kopek sonucKopek = null;
            foreach(Kopek kopek in Veriler.Kopekler)
            {
                if(kopek.Id == id)
                {
                    sonucKopek = kopek;
                    break;
                }
            }
            return sonucKopek;
        }
    }
}
