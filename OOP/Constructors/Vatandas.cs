namespace Constructors
{
    public class Vatandas
    {
        public string Adi { get; set; } // null;
        public string Soyadi { get; set; } // null;
        public string Ulke { get; set; } // = "Türkiye Cumhuriyeti";
        public string Sehir { get; set; }

        public Vatandas()
        {
            Ulke = "Türkiye Cumhuriyeti";
            Adi = "";
            Soyadi = string.Empty;
            Sehir = "";
        }

        public string UlkeVeSehirGetir() => $"Ülke / Sehir: {Ulke} / {Sehir}";

        public string AdSoyadGetir()
        {
            return "Adı Soyadı: " + Adi + " " + Soyadi;
        }
    }
}
