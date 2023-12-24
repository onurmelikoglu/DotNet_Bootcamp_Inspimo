using AbstractClassesDemo1.Bases;

namespace AbstractClassesDemo1
{
    public class YazilimDersi : DersBase
    {
        public double SonSinavNotu { get; set; }
        public override string KodGetir()
        {
            return "YZL-" + Id;
        }

        public override double DersNotuHesapla()
        {
            return Sinav1Notu * 0.2 + Sinav2Notu * 0.2 + SonSinavNotu * 0.6;
        }
    }
}
