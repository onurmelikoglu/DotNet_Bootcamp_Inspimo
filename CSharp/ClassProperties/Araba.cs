

namespace ClassProperties
{
    internal class Araba
    {
        public string Marka { get; set; } // property
        public string Model { get; set; }
        public int KapiSayisi { get; set; } = 4;
        public short BeygirGucu { get; set; }
        public double MotorHacmi { get; set; }
        public DateTime TrafigeCikisTarihi { get; set; }
        public ArabaTipi Turu { get; set; } = ArabaTipi.Binek;

    }
}
