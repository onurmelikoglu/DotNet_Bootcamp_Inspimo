using AbstractClassesDemo2.Classes.Bases;

namespace AbstractClassesDemo2.Classes
{
    public class Daire : YuvarlakSekilBase
    {
        public override double AlanHesapla()
        {
            return ( PiUcMu ? 3 : Math.PI ) * Math.Pow(Yaricap,2) ;
        }

        public override double CevreHesapla()
        {
            return ( PiUcMu ? 3 : Math.PI ) * Yaricap * 2 ;
        }
    }
}
