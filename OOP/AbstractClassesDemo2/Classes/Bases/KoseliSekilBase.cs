namespace AbstractClassesDemo2.Classes.Bases
{
    public abstract class KoseliSekilBase : IHesapla
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public abstract double AlanHesapla();
        public abstract double CevreHesapla();

    }
}
