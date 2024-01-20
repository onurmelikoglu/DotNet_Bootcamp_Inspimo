using ClassLibrary.Entities.Bases;

namespace ClassLibrary.Entities
{
    public class Tur : Kayit
    {
        public string Adi { get; set; }
        public Tur(string adi, int id) : base(id)
        {
            Adi = adi;
        }
    }
}