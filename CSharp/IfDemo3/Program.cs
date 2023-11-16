namespace IfDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                1. başla
                2. kullanıcya ad soyad sorulur
                3. kullanıcıya yaş sorulur
                4. kullanıcya eğitim durumu sorulur ( i: ilkokul veya altı, o: ortaokul, ü: üniversite veya üstü)
                5. eğer yaş 18'den küçük ise # adına git
                6. eğer yaş 18 den büyük veya eşitse
                7. eğer eğitim durumu i veya o ise # adıma git
                8. eğer eğitim durumu l veya ü
                9. ad soyadla birlikte ehliyet alamazsınız yazdır
                10. ad soyadla birlikte ehliyet alamazsınız yazdır
                11. bitir
            */

            string adSoyad, egitimDurumu, sonuc;
            int yas;
            Console.Write("Ad soyad: ");
            adSoyad = Console.ReadLine();
            Console.Write("Yas: ");
            yas = int.Parse(Console.ReadLine());
            Console.Write("Eğitim durumu (i: ilkokul veya altı, o: ortaokul, ü: üniversite veya üstü): ");
            egitimDurumu = Console.ReadLine();

            if(yas >= 18 && ( egitimDurumu == "l" || egitimDurumu == "ü" ) )
            {
                sonuc = adSoyad + ", ehliyet alabilirsiniz.";
            }
            else
            {
                sonuc = adSoyad + ", ehliyet alamazsınız.";
            }

            Console.WriteLine(sonuc);
        }
    }
}