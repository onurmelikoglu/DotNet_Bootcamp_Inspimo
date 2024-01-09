
using KopeklerimApp.Entities.Bases;

namespace KopeklerimApp.Entities
{
    public class Irk : Kayit
    {
        
        public string Adi { get; set; }
        public Ulkeler Ulke { get; set; }

        public Irk(string adi, Ulkeler ulke, int id) : base(id)
        {
            Adi = adi;
            Ulke = ulke;
        }
    }
}
