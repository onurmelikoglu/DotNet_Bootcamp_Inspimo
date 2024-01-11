using OgrenciYonetimApp.Entities;
using OgrenciYonetimApp.Enums;
using OgrenciYonetimApp.Repositories;
using System.Text;

namespace OgrenciYonetimApp
{
    internal class Program
    {
        private static readonly OgrenciRepo ogrenciRepo = new OgrenciRepo();
        private static readonly SinifRepo sinifRepo = new SinifRepo();
        static void Main(string[] args)
        {
            MenuOptions giris = MenuGetir();

            while (giris != MenuOptions.Cikis)
            {
                KullaniciIslemi(giris);
                giris = MenuGetir();
            }
           
        }

        private static MenuOptions MenuGetir()
        {
            StringBuilder menuBuilder = new StringBuilder();
            menuBuilder.AppendLine("\nİşlem");
            menuBuilder.AppendLine($"{(int)MenuOptions.Cikis}: Çıkış");
            menuBuilder.AppendLine($"{(int)MenuOptions.OgrenciListele}: Tüm Öğrencileri listele");
            menuBuilder.AppendLine($"{(int)MenuOptions.AdaGoreListele}: Ada göre Öğrencileri listele");
            menuBuilder.AppendLine($"{(int)MenuOptions.IdyeGoreOgrenciGetir}: ID' ye göre öğrenci yazdır");
            menuBuilder.AppendLine($"{(int)MenuOptions.OgrenciEkle}: Öğrenci ekle");
            menuBuilder.AppendLine($"{(int)MenuOptions.OgrenciGuncelle}: Öğrenci güncelle");
            menuBuilder.AppendLine($"{(int)MenuOptions.OgrenciSil}: Öğrenci sil");

            Console.WriteLine(menuBuilder.ToString());

            if (Enum.TryParse(Console.ReadLine(), out MenuOptions userInput))
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen tekrar deneyin.");
                return MenuGetir();
            }
        }

        private static void KullaniciIslemi(MenuOptions option)
        {
            switch (option)
            {
                case MenuOptions.OgrenciListele:
                    OgrencileriListele();
                    break;
                case MenuOptions.AdaGoreListele:
                    OgrencileriAdaGoreListele();
                    break;
                case MenuOptions.IdyeGoreOgrenciGetir:
                    OgrencileriIdyeGoreListele();
                    break;
                case MenuOptions.OgrenciEkle:
                    OgrenciEkle();
                    break;
            }
        }

      

        private static void OgrenciEkle()
        {
            Console.Write("\nAdı: ");
            string adi = Console.ReadLine();

            Console.Write("\nYaşı: ");
            int yasi;
            while (!int.TryParse(Console.ReadLine(), out yasi))
            {
                Console.WriteLine("Geçersiz yaş! Tekrar giriniz: ");
            }

            Console.Write("\nMezun Mu: (e: evet, h: hayır) ");
            bool mezunMu = Console.ReadLine().ToLower() == "e";

            List<Sinif> siniflar = sinifRepo.SiniflariGetir();
            Yazdir(siniflar);

            Console.Write("\nSınıf ID: ");
            int sinifId;
            while (!int.TryParse(Console.ReadLine(), out sinifId))
            {
                Console.WriteLine("Geçersiz ırk ID! Tekrar giriniz: ");
            }

            Console.WriteLine(ogrenciRepo.OgrenciEkle(adi, yasi, mezunMu, sinifId));
        }

        private static void Yazdir(List<Sinif> siniflar)
        {
            StringBuilder sinifText = new StringBuilder();
            sinifText.AppendLine("\nÖğrenci Bilgileri: ");
            foreach (Sinif sinif in siniflar)
            {
                sinifText.Append($"ID: {sinif.Id} ")
                        .Append($"Adı: {sinif.Adi}")
                        .Append("\n");
                
            }
            Console.WriteLine(sinifText.ToString());
        }

        private static void OgrencileriIdyeGoreListele()
        {
            Console.Write("\nÖğrenci ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Yazdir(ogrenciRepo.OgrencileriGetir(id));
        }

        private static void OgrencileriListele()
        {
            List<Ogrenci> ogrenciler = ogrenciRepo.OgrencileriGetir();
            Yazdir(ogrenciler);
        }

        private static void OgrencileriAdaGoreListele()
        {
            Console.Write("\nÖğrenci Adı: ");
            string adi = Console.ReadLine();
            Yazdir(ogrenciRepo.OgrencileriGetir(adi));
        }

        private static void Yazdir(List<Ogrenci> ogrenciler)
        {
           
           if(ogrenciler.Count > 0)
            {
                foreach (Ogrenci ogrenci in ogrenciler)
                {
                    YazdirOgrenciBilgileri(ogrenci);
                }
            }
            else
            {
                Console.WriteLine("Öğrenci bulunamadı.");
            }
            
        }

        private static void YazdirOgrenciBilgileri(Ogrenci ogrenci)
        {
            StringBuilder ogrenciText = new StringBuilder();
            ogrenciText.AppendLine("\nÖğrenci Bilgileri: ")
                     .AppendLine($"ID: {ogrenci.Id}")
                     .AppendLine($"Adı: {ogrenci.Adi}")
                     .AppendLine($"Yaşı: {ogrenci.Yasi}")
                     .AppendLine($"Sınıfı: {ogrenci.Sinifi.Adi}")
                     .Append($"Mezun Mu: {(ogrenci.MezunMu ? "Evet" : "Hayır")}");

            Console.WriteLine(ogrenciText.ToString());
        }
    }
}
