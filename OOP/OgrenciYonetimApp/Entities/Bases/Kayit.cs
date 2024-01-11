
namespace OgrenciYonetimApp.Entities.Bases
{
    public abstract class Kayit
    {
        public int Id { get; set; }

        protected Kayit(int id)
        {
            Id = id;
        }

        protected Kayit()
        {

        }
    }
}
