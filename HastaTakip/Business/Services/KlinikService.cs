
using Business.Models;
using DataAccess.Contexts;

namespace Business.Services
{
    public interface IKlinikService
    {
        IQueryable<KlinikModel> Query();
    }
    public class KlinikService : IKlinikService
    {
        private readonly Db db;

        public KlinikService(Db db)
        {
            this.db = db;
        }

        public IQueryable<KlinikModel> Query()
        {
            return db.Klinikler.OrderBy(klinik => klinik.Adi).Select(klinik => new KlinikModel
            {
                Id = klinik.Id,
                Adi = klinik.Adi,
                Aciklamasi = klinik.Aciklamasi,
                Guid = klinik.Guid,
            }); // klinik : her bir klinik eleman delegesi
        }
    }
}
