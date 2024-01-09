
namespace KopeklerimApp.Entities.Bases
{
    public abstract class Kayit
    {
        public int Id { get; private set; }

        public Kayit(int id)
        {
            Id = id;
        }
    }
}
