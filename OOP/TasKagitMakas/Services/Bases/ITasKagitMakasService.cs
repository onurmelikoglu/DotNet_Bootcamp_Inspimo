

namespace TasKagitMakas.Services.Bases
{
    public interface ITasKagitMakasService
    {
        void YeniOyunaBasla();

        string Oyna(char oyuncuHareketi, string sonuc = null);
    }
}
