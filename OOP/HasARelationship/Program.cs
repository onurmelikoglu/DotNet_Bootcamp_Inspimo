

using HasARelationship.Entities;
using HasARelationship.Entities.Bases;
using HasARelationship.Repositories;

namespace HasARelationship
{
    internal class Program
    {
        private static GokCismiRepo repo = new GokCismiRepo();
        static void Main(string[] args)
        {
            string giris = MenuGetir();

            while(giris != "0")
            {
                switch (giris)
                {
                    case "1":
                        TipeGoreYazdir(); break;
                }
                giris = MenuGetir();
            }
        }

        private static void TipeGoreYazdir()
        {
            Console.WriteLine("\nGök cismi tipi seçiniz\n" + 
                "1: Tümü\n" +
                "2: Yıldız\n" +
                "3: Gezegen\n" + 
                "4. Uydu"
                );
            int tip = Convert.ToInt32( Console.ReadLine() );
            List<GokCismiBase> gokCisimleri = repo.Getir((GokCismiTipi)tip);
            repo.Yazdir(gokCisimleri);
        }

        private static string MenuGetir()
        {
            Console.WriteLine("\nİşlem Seçiniz\n" + 
                "0: Çıkış\n" +
                "1: Tipe göre gök Cisimlerini yazdır\n" + 
                "2: Ada ve ad eşitliğine göre gök cisimlerini ara"
                );
            return Console.ReadLine();
        }
    }
}
