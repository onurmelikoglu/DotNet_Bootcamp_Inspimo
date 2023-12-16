namespace Inheritance
{
    public class Takim
    {
        #region Properties
        public string Adi { get; set; }
        public short KurulusYili { get; set; }
        public string Sehir { get; set; }
        #endregion



        #region Behaviors
        public string BilgiGetir()
        {
            return $"Takım: {Adi}\nKuruluş Yılı: {KurulusYili}";
        }
        #endregion
    }
}
