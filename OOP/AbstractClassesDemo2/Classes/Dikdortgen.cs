using AbstractClassesDemo2.Classes.Bases;

namespace AbstractClassesDemo2.Classes
{
    internal class Dikdortgen : KoseliSekilBase
    {
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }

        public override double CevreHesapla()
        {
            return 2 * (Genislik * Yukseklik);
        }
    }
}
