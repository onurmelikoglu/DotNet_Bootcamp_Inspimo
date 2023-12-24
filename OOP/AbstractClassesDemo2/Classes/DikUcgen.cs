using AbstractClassesDemo2.Classes.Bases;

namespace AbstractClassesDemo2.Classes
{
    public class DikUcgen : KoseliSekilBase
    {
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik / 2;    
        }

        public override double CevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(Genislik, 2) + Math.Pow(Yukseklik, 2));
            return hipotenus + Genislik + Yukseklik;
        }

    }
}
