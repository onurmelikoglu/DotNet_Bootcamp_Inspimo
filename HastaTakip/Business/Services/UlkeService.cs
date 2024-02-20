using Business.Models;
using DataAccess.Contexts;

namespace Business.Services
{
    public abstract class UlkeServiceBase
    {
        protected readonly Db db;

        protected UlkeServiceBase(Db db)
        {
            this.db = db;
        }

        public virtual IQueryable<UlkeModel> Query()
        {
            return db.Ulkeler.OrderBy(u => u.Adi).Select(u => new UlkeModel()
            {
                Adi = u.Adi,
                Guid = u.Guid,
                Id = u.Id
            });
        }

        public virtual List<UlkeModel> GetList() => Query().ToList();
    }

    public class UlkeService : UlkeServiceBase
    {
        public UlkeService(Db db) : base(db)
        {
        }
    }
}