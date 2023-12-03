
namespace Encapsulation
{
    class Musteri
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public byte Yasi { get; set; }
        public bool KadinMi { get; set; }
        //public string Cinsiyet { get { return KadinMi == true ? "Kadın" : "Erkek"; } }
        public string Cinsiyet =>  KadinMi == true ? "Kadın" : "Erkek";

        //public string UnvanliAdSoyadGetir()
        //{
        //    return KadinMi ? "Bayan " : "Bay " + Adi + " " + Soyadi;
        //}

        public string UnvanliAdSoyadGetir() => ( KadinMi ? "Bayan " : "Bay " ) + Adi + " " + Soyadi;

        string _kartNo;
        public string KartNo 
        {
            get
            {
                if(_kartNo is null)
                    return string.Empty;
                else if(_kartNo.Length != 19)
                    return string.Empty;
                else
                    return "**** **** **** " + _kartNo.Substring(15);
            }
            set
            {
                _kartNo = value;
            }
        }

        public string AdSoyadGetir()
        {
            return Adi + " " + Soyadi;
        }
    }
}
