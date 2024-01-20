
namespace ClassLibrary.Entities.Bases
{
    public abstract class Kayit
    {
        public int Id { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }

        // this önce default olanı çağırır
        protected Kayit(int id) : this() 
        {
            Id = id;
        }

        protected Kayit() // default constructor
        {
            OlusturulmaTarihi = DateTime.Now;
        }
    }
}
