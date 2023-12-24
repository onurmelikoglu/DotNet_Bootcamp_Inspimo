namespace AbstractClassesDemo1.Bases
{
    public abstract class DersBase
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Sinav1Notu { get; set; }
        public double Sinav2Notu { get; set; }

        public abstract string KodGetir();
        public virtual double MaksimumNotGetir() => 100;
        public virtual double DersNotuHesapla() => Sinav1Notu * 0.5 + Sinav2Notu * 0.5;
    }
}
