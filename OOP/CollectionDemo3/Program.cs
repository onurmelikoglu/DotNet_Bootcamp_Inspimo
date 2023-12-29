using CollectionsDemo3.Models;
using System.Globalization;

namespace CollectionsDemo3
{
    internal class Program
    {

        static List<Organizasyon> organizasyonlar;
        private static int enSonOrganizasyonId = 1;
        static void Main(string[] args)
        {
            string giris;
            int id;
            Organizasyon organizasyon;

            Console.Write("İşlem: (e: ekle, s: sil, y: yazdır, a: ara, ç: çıkış) ");
            giris = Console.ReadLine().ToLower().Trim();

            while (giris != "ç")
            {
                if(giris == "e")
                {
                    organizasyon = KullaniciGirisi();
                    Ekle(organizasyon); 
                    Console.WriteLine("Organizasyon ekleme işlemi başarıyla gerçekleştirildi.");
                }
                else if (giris == "s") 
                {
                    Console.Write("Silmek istediğiniz organizasyonun ID'sini giriniz: ");
                    id = int.Parse(Console.ReadLine());
                    if (Sil(id)) 
                    {
                        Console.WriteLine("Organizasyon silme işlemi başarıyla gerçekleştirildi.");
                    }
                    else 
                    {
                        Console.WriteLine("Organizasyon silme işlemi gerçekleştirilemedi!");
                    }
                }
                else if (giris == "y") 
                {
                    Yazdir();
                }
                else if (giris == "a") 
                {
                    Console.Write("Aramak istediğiniz organizasyonun ID'sini giriniz: ");
                    id = int.Parse(Console.ReadLine());
                    organizasyon = Ara(id);
                    if (organizasyon is null) 
                    {
                        Console.WriteLine("Organizasyon bulunamadı!");
                    }
                    else 
                    {
                        Yazdir(organizasyon);
                    }
                }
                else 
                {
                    Console.WriteLine("Geçersiz işlem!");
                }
                Console.Write("Organizasyon işlemi seçiniz: (e: ekle, s: sil, y: yazdır, a: ara, ç: çıkış) ");
                giris = Console.ReadLine().ToLower().Trim();
            }

            Console.WriteLine("Hoşçakalın.");
        

        }

        static void Ekle(Organizasyon organizasyon)
        {
            organizasyonlar.Add(organizasyon);
        }

        private static Organizasyon Ara(int id)
        {
            Organizasyon bulunanOrganizasyon = null;
            foreach (Organizasyon organizasyon in organizasyonlar)
            {
                if (organizasyon.Id == id)
                {
                    bulunanOrganizasyon = organizasyon;
                    break;
                }
            }
            return bulunanOrganizasyon;
        }

        private static bool Sil(int id)
        {
            Organizasyon organizasyon = Ara(id);
            if (organizasyon is null)
                return false;
                organizasyonlar.Remove(organizasyon);
            return true;
        }

        static Organizasyon KullaniciGirisi()
        {
            Organizasyon organizasyon = new Organizasyon()
            {
                Id = enSonOrganizasyonId++
            };

            Console.Write("Adı: ");
            organizasyon.Adi = Console.ReadLine().Trim();
            Console.Write("Düzenleyen: ");
            organizasyon.Duzenleyeni = Console.ReadLine().Trim();
            Console.Write("Başlangıç Tarihi ve saati (gün.ay.yıl saat:dakika): ");
            organizasyon.BaslangicTarihiVeSaati = DateTime.Parse(Console.ReadLine().Trim(), new CultureInfo("tr-TR"));
            Console.Write("Süresi (saat:dakika) (maksimum 23:59)");
            organizasyon.Suresi = TimeSpan.Parse(Console.ReadLine().Trim());

            return organizasyon;

        }

        private static void Yazdir(Organizasyon organizasyon)
        {
            string sonuc = "";
            sonuc += $"{organizasyon.Id} ID'li Organizasyon:\n";
            sonuc += $"Adı: {organizasyon.Adi}\n";
            sonuc += $"Düzenleyen: {organizasyon.Duzenleyeni}\n";
            sonuc += $"Başlangıç Tarihi: {organizasyon.BaslangicTarihiVeSaati.ToString("dd.MM.yyyy HH:mm")}\n";
            sonuc += $"Bitis Tarihi: {organizasyon.BitisTarihiVeSaati.ToString("dd.MM.yyyy HH:mm")}\n";
            sonuc += $"Süresi (saat:dakika): {organizasyon.Suresi.ToString(@"hh\:mm")}\n";
            sonuc += $"Toplam Süresi (dakika): {organizasyon.Suresi.TotalMinutes}";
            Console.WriteLine(sonuc);
        }

        private static void Yazdir()
        {
            foreach (Organizasyon organizasyon in organizasyonlar)
            {
                Yazdir(organizasyon);
            }
            Console.WriteLine("Toplam " + organizasyonlar.Count + " adet organizasyon bulundu.");
        }

        
    }
}
