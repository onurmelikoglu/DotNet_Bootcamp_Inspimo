using InterfacesDemo.Classes.Bases;

namespace InterfacesDemo.Classes
{
    internal class Daire : IYuvarlakSekil
    {
        public double Yaricap { get; set; }
        public bool PiUcMu { get; set; }

        double pi;

        public Daire(double yariCap, bool piUcMu = false)
        {
            Yaricap = yariCap;
            PiUcMu = piUcMu;
            pi = PiUcMu ? 3 : Math.PI;
        }

        public double AlanHesapla()
        {
            return pi * Math.Pow(Yaricap, 2);
        }

        public double CevreHesapla()
        {
            return 2 * pi * Yaricap;
        }
    }
}
