
using OgrenciYonetimApp.Entities.Bases;

namespace OgrenciYonetimApp.Entities
{
    public class Ogrenci : Kayit
    {
        public string Adi { get; set; }
        public int Yasi { get; set; }
        public bool MezunMu { get; set; }
        public Sinif Sinifi { get; set; }

    }
}
