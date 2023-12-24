using InterfaceVsAbstractClass1.Bases;
using System.Text;

namespace InterfaceVsAbstractClass1
{
    public class MetinselOgrenciDosya : OgrenciDosyaBase
    {

        public override void OgrenciEkle(string ogrenci)
        {
            File.AppendAllText(DosyaYolu, "\n" + ogrenci, Encoding.UTF8);
        }

        public override string OgrencileriGetir(bool sayiEkle)
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
