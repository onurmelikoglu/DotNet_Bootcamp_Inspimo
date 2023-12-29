namespace ListCollectionType.Models
{
    public class Sehir
    {
        public byte PlakaNo { get; set; }
        public string Adi { get; set; }

        public Sehir()
        {

        }

        public Sehir(byte plakaNo, string adi)
        {
            PlakaNo = plakaNo;
            Adi = adi;
        }
    }
}
