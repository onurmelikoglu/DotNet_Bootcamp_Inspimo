namespace Inheritance
{
    public class FutbolTakimi : Takim
    {
        #region Properties
        public string TeknikDirektorAdi { get; set; }
        public string KaleciAdi { get; set; }
        public string DefansOyuncuAdlari { get; set; }
        public string OrtaSahaOyuncuAdlari { get; set; }
        public string ForvetOyuncuAdlari { get; set; }
        public string OyunSistemi { get; set; }
        #endregion



        #region Behaviors
        public string KadroGetir()
        {
            return $"Teknik Direktör: {TeknikDirektorAdi}\nKaleci: {KaleciAdi}\n" +
                $"Defans Oyuncuları: {DefansOyuncuAdlari}\nOrta Saha Oyuncuları: {OrtaSahaOyuncuAdlari}\nForvet Oyuncuları: {ForvetOyuncuAdlari}";
        }
        #endregion
    }
}
