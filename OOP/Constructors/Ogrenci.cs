namespace Constructors
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        decimal vize1; // 0
        decimal vize2; // 0
        decimal final; // 0

        const decimal vize1carpan = 0.2m;
        const decimal vize2carpan = 0.2m;
        const decimal finalcarpan = 0.2m;

        decimal ortalama;

        public Ogrenci(string adi, string soyadi, decimal vize1, decimal vize2, decimal final)
        {
            Adi = adi;
            Soyadi = soyadi;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
        }

        public Ogrenci(decimal vize1, decimal vize2, decimal final)
        {
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
        }

        public Ogrenci()
        {

        }

        public void OrtalamaHesaplama()
        {
            decimal ortalama; // lokal variable
            ortalama = vize1 * vize1carpan + vize2 * vize2carpan + final * finalcarpan;
            this.ortalama = ortalama;
          
        }

        public string Getir()
        {
            string sonuc = "Öğrenci: " + Adi + " " + Soyadi;
            sonuc +="\nOrtalama: " +  ortalama.ToString("N1");
            sonuc += "\nDurum" + (ortalama >= 60 ? "Geçti" : "Kaldı");
            return sonuc;
        }
    }
}
