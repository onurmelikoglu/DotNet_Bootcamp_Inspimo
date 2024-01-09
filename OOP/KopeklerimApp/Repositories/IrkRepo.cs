

using KopeklerimApp.Data;
using KopeklerimApp.Entities;

namespace KopeklerimApp.Repositories
{
    public class IrkRepo
    {
        public List<Irk> IrklariGetir()
        {
            return Veriler.Irklar;
        }
    }
}
