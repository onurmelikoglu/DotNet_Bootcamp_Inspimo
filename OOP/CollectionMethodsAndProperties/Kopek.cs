namespace CollectionMethodsAndProperties
{
    public class Kopek
    {
        string adi;
        string irki;
        byte yasi;
        bool erkekMi;

        public Kopek(string adi, string irki, byte yasi, bool erkekMi)
        {
            this.adi = adi;
            this.irki = irki;
            this.yasi = yasi;
            this.erkekMi = erkekMi;
        }

        public override string ToString()
        {
            return $"Adı: {adi}\nIrkı: {irki}\nYaşı: {yasi}\nCinsiyeti: {(erkekMi ? "Erkek":"Dişi")}";
        }
    }
}
