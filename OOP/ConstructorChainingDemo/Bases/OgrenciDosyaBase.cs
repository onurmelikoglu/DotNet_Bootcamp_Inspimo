
using ConstructorChainingDemo.Models;
using System.Text;

namespace ConstructorChainingDemo.Bases
{
    public abstract class OgrenciDosyaBase
    {
        protected string dosyaYolu;

        protected OgrenciDosyaBase(string dosyaYolu)
        {
            this.dosyaYolu = dosyaYolu;
        }

        public virtual List<Ogrenci> OgrencileriGetir()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            Ogrenci ogrenci;

            string satir;

            StreamReader streamReader = new StreamReader(dosyaYolu, Encoding.UTF8);

            while(( satir = streamReader.ReadLine() ) is not null)
            {
                ogrenci = new Ogrenci()
                {
                    Adi = satir.Split('-')[0],
                    Soyadi = satir.Split('-')[1],
                    Yasi = Convert.ToByte(satir.Split('-')[2])
                };
                ogrenciler.Add(ogrenci);
            }

            streamReader.Dispose();

            return ogrenciler;

        }

        public virtual List<Ogrenci> OgrencileriGetir2()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            Ogrenci ogrenci;

            string satir;

            // using otomatik kullanıp dispose ediyor
            using (StreamReader streamReader = new StreamReader(dosyaYolu, Encoding.UTF8))
            {
                while ((satir = streamReader.ReadLine()) is not null)
                {
                    ogrenci = new Ogrenci()
                    {
                        Adi = satir.Split('-')[0],
                        Soyadi = satir.Split('-')[1],
                        Yasi = Convert.ToByte(satir.Split('-')[2])
                    };
                    ogrenciler.Add(ogrenci);
                }
            };

            return ogrenciler;

        }

        public virtual void OgrenciEkle(Ogrenci ogrenci)
        {
            string satir = $"{ogrenci.Adi}-{ogrenci.Soyadi}-{ogrenci.Yasi}";

            using (StreamWriter streamWriter = new StreamWriter(dosyaYolu, true, Encoding.UTF8))
            {
                streamWriter.Write("\n" + satir);
            };
        }


    }
}
