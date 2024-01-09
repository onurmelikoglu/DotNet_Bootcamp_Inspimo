
using KopeklerimApp.Entities.Bases;

namespace KopeklerimApp.Entities
{
    public class Kopek : Kayit
    {
        public string Adi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool ErkekMi { get; set; }
        public Irk Irki { get; set; }

        public Kopek(int id) : base(id)
        {

        }

    }
}
