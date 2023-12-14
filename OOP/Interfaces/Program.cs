namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = "Çağıl",
                Soyadi = "Alsaç",
                TcKimlikNo = "11112223333",
                Universite = "bilkent"
            };

            Console.WriteLine(ogrenci.Getir() + "\nÜniversite: " + ogrenci.Universite);

            Musteri musteri = new Musteri()
            {
                Adi = "Çağıl",
                Soyadi = "Alsaç",
                TcKimlikNo = "11112223333",
                KrediKartiNo = "1111 2222 3333 4444"
            };


            IKisi kisi = new Ogrenci()
            {
                Adi = "Luna",
                Soyadi = "Alsaç",
                TcKimlikNo = "111133444",
                Universite = "Kopek"
            };

            Console.WriteLine(kisi.Getir());

            kisi = new Ogrenci()
            {
                Adi = "Luna",
                Soyadi = "Alsaç",
                TcKimlikNo = "111133444",
                Universite = "Kopek"
            };
            // string universite = ((Ogrenci)kisi).Universite;
            string universite = (kisi as Ogrenci).Universite;
            Console.WriteLine(kisi.Getir() + "\nUniversite: " + universite);
            Console.WriteLine(kisi.Getir());

            kisi = new Musteri()
            {
                Adi = "Luna",
                Soyadi = "Alsaç",
                TcKimlikNo = "111133444",
                KrediKartiNo = "9999 8888 7777 6666"
            };

            Console.WriteLine(kisi.Getir() + "\nKart No: " + ((Musteri)kisi).KrediKartiNoGizle() );

            kisi = new Musteri();
            kisi.Adi = "Veli";
            kisi.Soyadi = "Tantan";
            kisi.TcKimlikNo = "9999";
            Musteri musteriKisi = kisi as Musteri;
            musteriKisi.KrediKartiNo = "5555 8888 9999 7777";

            Console.WriteLine(musteriKisi.Adi + " " + musteriKisi.Soyadi + musteriKisi.KrediKartiNo);

        }
    }
}
