namespace OgrenciDemo.Models
{
    class Ogrenci
    {

        const decimal vize1carpan = 0.2m;
        const decimal vize2carpan = 0.2m;
        const decimal finalcarpan = 0.6m;

        public Ogrenci(string adi, string soyadi, decimal vize1, decimal vize2, decimal final)
        {
            Adi = adi;
            Soyadi = soyadi;
            Vize1 = vize1;
            Vize2 = vize2;
            Final = final;
        }

        public Ogrenci()
        {

        }

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public decimal Vize1 { get; set; }
        public decimal Vize2 { get; set; }
        public decimal Final { get; set; }
        public decimal Ortalama => vize1carpan * Vize1 + vize2carpan * Vize2 + finalcarpan * Final;

        public string Durum => Ortalama >= 60 ? "Geçti" : "Kaldı";
    }
}
