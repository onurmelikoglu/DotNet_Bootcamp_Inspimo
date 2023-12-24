using Polimorphism.Enums;

namespace Polimorphism.Models.Bases
{
    public class VideoOyunu
    {
        public string Adi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string[] Turleri { get; set; }
        public OyuncuSayisi OyuncuSayisi { get; set; }

        public string TurleriGosterim 
        { 
            get
            {
                string turler = "";
                if(Turleri is not null)
                {
                    foreach(string turu in Turleri)
                    {
                        turler += turu + ", ";
                    }

                    // turler = turler.Substring(0, turler.Length - 2);
                    //turler = turler.TrimEnd(',',' ');
                    turler = turler.TrimEnd(", ".ToCharArray());

                }
                return turler;
            }
        }

        public string OyuncuSayisiGosterim
        {
            get
            {
                // OyuncuSayisi oyuncuSayisi = OyuncuSayisi.TekOyuncu | OyuncuSayisi.ÇokOyuncu;
                string oyuncuSayisi;

                if (OyuncuSayisi.HasFlag(OyuncuSayisi.TekOyuncu) && OyuncuSayisi.HasFlag(OyuncuSayisi.ÇokOyuncu))
                    oyuncuSayisi = "Hem Tek Hem Çok";
                else if (OyuncuSayisi == OyuncuSayisi.TekOyuncu)
                    oyuncuSayisi = "Tek";
                else
                    oyuncuSayisi = "Çok";

                return oyuncuSayisi + " Oyunculu";

            }
        }
    }
}
