
using HasARelationship.Entities;
using HasARelationship.Entities.Bases;
using System.Globalization;

namespace HasARelationship.Repositories
{
    public class GokCismiRepo
    {
        private List<GokCismiBase> gokCisimleri;

        public GokCismiRepo()
        {
            gokCisimleri = new List<GokCismiBase>();
            Yildiz yildiz = new Yildiz()
            {
                Adi = "Güneş",
                KendiEtrafindaDonmeHizi = 2000,
                SicaklikC = 5500,
                YariCapi = 696340
            };
            Gezegen gezegen1 = new Gezegen()
            {
                Adi = "Mars",
                KendiEtrafindaDonmeHizi = 3000,
                YariCapi = 3389.5,
                YasamVarMi = false,
                Yildiz = yildiz
            };
            yildiz.Gezegenler.Add(gezegen1);

            Gezegen gezegen2 = new Gezegen()
            {
                Adi = "Dünya",
                KendiEtrafindaDonmeHizi = 3500,
                YariCapi = 6371,
                YasamVarMi = true,
                Yildiz = yildiz
            };

            yildiz.Gezegenler.Add(gezegen2);

            Uydu uydu = new Uydu()
            {
                Adi = "Ay",
                YariCapi = 1737.4,
                KendiEtrafindaDonmeHizi = 4000,
                Gezegen = gezegen2
            };

            gezegen2.Uydular.Add(uydu);

            gokCisimleri.Add(yildiz);
            gokCisimleri.Add(gezegen1);
            gokCisimleri.Add(gezegen2);
            gokCisimleri.Add(uydu);
        }

        public List<GokCismiBase> Getir(GokCismiTipi tipi = GokCismiTipi.Tumu)
        {
            List<GokCismiBase> sonucGokCisimleri = new List<GokCismiBase>();
            foreach(GokCismiBase gokCismi in gokCisimleri)
            {
                if(gokCismi is Yildiz && tipi == GokCismiTipi.Yildiz)
                {
                    sonucGokCisimleri.Add(gokCismi);
                }
                else if(gokCismi is Gezegen && tipi == GokCismiTipi.Gezegen)
                {
                    sonucGokCisimleri.Add(gokCismi);
                }
                else if(gokCismi is Uydu && tipi == GokCismiTipi.Uydu)
                {
                    sonucGokCisimleri.Add(gokCismi);
                }
            }
            return sonucGokCisimleri;
        }

        public void Yazdir(List<GokCismiBase> gokCisimleri)
        {
            Yildiz yildiz;
            Gezegen gezegen;
            Uydu uydu;

            foreach(var gokCismi in gokCisimleri)
            {
                if(gokCismi is Yildiz)
                {
                    yildiz = gokCismi as Yildiz;
                    Console.WriteLine("\nTipi: Yıldız\n" +
                    $"Adı: {yildiz.Adi}\n" +
                        $"Yarı Çapı: {yildiz.YariCapi.ToString(new CultureInfo("tr-TR"))} km\n" +
                        $"Kendi Etrafında Dönme Hızı: {yildiz.KendiEtrafindaDonmeHizi.ToString(new CultureInfo("tr-TR"))} km/h\n" +
                    $"Sıcaklık: {yildiz.SicaklikC.ToString(new CultureInfo("tr-TR"))} C ({yildiz.SicaklikF.ToString(new CultureInfo("tr-TR"))} F)");
                }
                else if(gokCismi is Gezegen)
                {
                    gezegen = gokCismi as Gezegen;
                    Console.WriteLine("\nTipi: Gezegen\n" +
                        $"Adı: {gezegen.Adi}\n" +
                        $"Yarı Çapı: {gezegen.YariCapi.ToString(new CultureInfo("tr-TR"))} km\n" +
                        $"Kendi Etrafında Dönme Hızı: {gezegen.KendiEtrafindaDonmeHizi.ToString(new CultureInfo("tr-TR"))} km/h\n" +
                        $"Yaşam: {(gezegen.YasamVarMi ? "Var" : "Yok")}");
                }
            }
        }

    }
}
