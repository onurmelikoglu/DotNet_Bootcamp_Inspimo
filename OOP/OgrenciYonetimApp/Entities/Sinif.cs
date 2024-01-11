using OgrenciYonetimApp.Entities.Bases;

namespace OgrenciYonetimApp.Entities
{
    public class Sinif : Kayit
    {
        public string Adi { get; set; }
        public Sinif(int id, string adi) : base(id)
        {
            Adi = adi;
        }
    }
}
