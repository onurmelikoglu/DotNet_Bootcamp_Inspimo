using System.Text;

namespace InterfaceVsAbstractClass1.Bases
{
    public abstract class OgrenciDosyaBase
    {
        public string DosyaYolu { get; set; }

        public abstract string OgrencileriGetir(bool sayiEkle);

        public abstract void OgrenciEkle(string ogrenci);

        public string DosyaUzantisiGetir()
        {
            string dosya = Path.GetExtension(DosyaYolu); // .jpg
            return dosya.Substring(1); // jpg
        }
        public string DosyaAdiGetir()
        {
            string dosya = Path.GetFileName(DosyaYolu); // cagil.jpg
            return dosya.Split('.')[0]; // cagil
        }
    }
}
