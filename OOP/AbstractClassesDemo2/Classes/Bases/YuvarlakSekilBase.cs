namespace AbstractClassesDemo2.Classes.Bases
{
    public abstract class YuvarlakSekilBase : IHesapla
    {
        public double Yaricap { get; set; }
        public bool PiUcMu { get; set; } = true;
        public abstract double AlanHesapla();
        public abstract double CevreHesapla();
    }
}
