using InterfacesDemo.Classes.Bases;

namespace InterfacesDemo.Classes
{
    public class Dikdortgen : IKoseliSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }

        public double CevreHesapla()
        {
            return 2 * ( Genislik * Yukseklik );
        }
    }
}
