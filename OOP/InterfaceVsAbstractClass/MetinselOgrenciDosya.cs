using InterfaceVsAbstractClass.Bases;
using System.Text;

namespace InterfaceVsAbstractClass
{
    public class MetinselOgrenciDosya : IOgrenciDosya
    {
        public string DosyaYolu { get; set; }

        public string DosyaAdiGetir()
        {
            string dosya = Path.GetFileName(DosyaYolu); // cagil.jpg
            return dosya.Split('.')[0]; // cagil
        }

        public string DosyaUzantisiGetir()
        {
            string dosya = Path.GetExtension(DosyaYolu); // .jpg
            return dosya.Substring(1); // jpg
        }

        public void OgrenciEkle(string ogrenci)
        {
            File.AppendAllText(DosyaYolu, "\n" + ogrenci, Encoding.UTF8);
        }

        public string OgrencileriGetir(bool sayiEkle)
        {
            string ogrenciler = "";

            if (!sayiEkle)
            {
                ogrenciler = File.ReadAllText(DosyaYolu, Encoding.UTF8);
            }
            else
            {
                string[] ogrenciDisizi = File.ReadAllLines(DosyaYolu, Encoding.UTF8);
                int satirNo = 1;
                foreach(string ogrenciElemani in ogrenciDisizi)
                {
                    ogrenciler += satirNo + ") " + ogrenciElemani + "\n";
                    satirNo++;
                }
                ogrenciler = ogrenciler.TrimEnd('\n');
            }
           

            return ogrenciler;
        }
    }
}
