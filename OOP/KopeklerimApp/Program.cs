using KopeklerimApp.Entities;
using KopeklerimApp.Repositories;

namespace KopeklerimApp
{
    internal class Program
    {
        private static readonly KopekRepo kopekRepo = new KopekRepo();
        private static readonly IrkRepo irkRepo = new IrkRepo();
        static void Main(string[] args)
        {
            string giris = MenuGetir();

            while(giris != "0")
            {
                switch (giris)
                {
                    case "1":
                        KopekleriListele();
                        break;
                    case "2":
                        AdaGoreKopekleriListele();
                        break;
                    case "3":
                        IdyeGoreKopekleriGetir();
                        break;
                    case "4":
                        KopekEkle();
                        break;
                }
                giris = MenuGetir();
            }

            KopekleriListele();
        }

        private static void KopekEkle()
        {
            Console.WriteLine("\nAdı\n");
            string adi = Console.ReadLine();
            Console.Write("Doğum Tarihi: ");

            List<Irk> irklar = irkRepo.IrklariGetir();
            Yazdir(irklar);
            Console.Write("IRK ID: ");
            int irkId;
            if(!int.TryParse(Console.ReadLine(), out irkId))
            {
                Console.WriteLine("Geçersiz ırk ID!");
                return;
            }
            // kopekRepo.KopekEkle(adi, dogumTarihi, cinsiyeti, int irkId);
        }

        private static void Yazdir(List<Irk> irklar)
        {
            foreach(Irk irk in irklar)
            {
                Console.Write("\nIrk\n" +
                    "ID: " + irk.Id + "\n" +
                    "Adı: " + irk.Adi + "\n" +
                    "Ülkesi: " + irk.Ulke + "\n"
                    );
            }
        }

        private static void IdyeGoreKopekleriGetir()
        {
            Console.Write("\nKöpek ID: ");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());
                Yazdir(kopekRepo.KopekGetir(id));
            }
            catch(Exception e)
            {
                Console.WriteLine("Lütfen sayısal değer giriniz! Hata :  " + e.Message);
            }
            
            
        }

        private static void AdaGoreKopekleriListele()
        {
            Console.Write("\nKöpek Adı: ");
            string adi = Console.ReadLine();
            Yazdir(kopekRepo.KopekleriGetir(adi));
        }

        private static string MenuGetir()
        {
            Console.WriteLine(
                "\nİşlem\n" +
                "0: Çıkış\n" +
                "1: Tüm köpekleri listele\n" +
                "2: Ada göre köpekleri listele\n" +
                "3: ID' ye göre köpeği yazdır\n" +
                "5: Köpek ekle\n" +
                "6: Köpek güncelle\n" +
                "7: Köpek sil"
                );
            return Console.ReadLine();
        }

        static void KopekleriListele()
        {
            List<Kopek> kopekler = kopekRepo.KopekleriGetir();
            Yazdir(kopekler);
        }

        static void Yazdir(List<Kopek> kopekler)
        {
            foreach(Kopek kopek in kopekler)
            {
                Yazdir(kopek);
            }
        }

        private static void Yazdir(Kopek kopek)
        {
            string kopekText, irkText;
            kopekText = "\nKöpeğim\n" +
                "ID: " + kopek.Id + "\n" +
                "Adı: " + kopek.Adi + "\n" +
                "Doğum Tarih: " + kopek.DogumTarihi.ToString("dd.MM.yyyy HH:mm:ss") + "\n" +
                "Cinsiyeti: " + (kopek.ErkekMi ? "Erkek" : "Dişi");
            irkText = "\nIRK\n" +
                "ID: " + kopek.Id + "\n" +
                "Adı: " + kopek.Adi + "\n" +
                "Ülkesi: " + kopek.Irki.Ulke;
            Console.WriteLine(kopekText + irkText);
        }
    }
}
