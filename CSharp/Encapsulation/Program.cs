namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Çağıl";
            musteri1.Soyadi = "Alsaç";
            musteri1.Yasi = 43;
            musteri1.KartNo = "1111 2222 3333 4444";
            musteri1.KadinMi = false;
            Console.WriteLine(musteri1.AdSoyadGetir() + " " + musteri1.Yasi + " Kart No:  " + musteri1.KartNo + "Cinsiyet : " + musteri1.Cinsiyet);

            Musteri musteri2 = new Musteri()
            {
                Adi = "Luna",
                Soyadi = "Alsac",
                KartNo = "1111 2222 3333 4444",
                KadinMi = true
            };
            Console.WriteLine(musteri2.UnvanliAdSoyadGetir());
        }
    }
}
