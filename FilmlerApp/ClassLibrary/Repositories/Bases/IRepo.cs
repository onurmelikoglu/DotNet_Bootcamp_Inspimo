
using ClassLibrary.Entities.Bases;

namespace ClassLibrary.Repositories.Bases
{
    public interface IRepo
    {
        Kayit KayitGetir(int id);
        List<Kayit> KayitlariGetir();

    }
}
