namespace InterfacesDemo.Classes
{
    public class EskenarUcgen
    {
        public double Genislik { get; set; }
        public double AlanHesapla()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(Genislik, 2);
        }

        public double CevreHesapla()
        {
            return 3 * Genislik;
        }
    }
}
