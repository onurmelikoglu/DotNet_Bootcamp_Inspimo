
namespace ClassProperties
{
    internal class Bilgisayar
    {
        public int Id { get; set; } // identity (objenin kimlik numarası)
        public string Marka { get; set; }
        public string Model { get; set; }
        public BilgisayarTipi Tipi { get; set; }
        public double GHz { get; set; }
        public short Hafiza { get; set; }
        public double EkranBoyutu { get; set; }
        public bool SuSogutmaliMi { get; set; }
        public DateTime UretimTarihi { get; set; }
    }
}
