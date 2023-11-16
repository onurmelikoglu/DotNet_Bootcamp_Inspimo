namespace Switch
{
    internal class Program
    {
        // hesap makinesi 4 işlem için
        // kullanıcıdan 1. sayı alınsın
        // kullanıcıdan işlem alınsın (+, -, /, *)
        // kullanıcıdan 2. sayı alınsın
        // sonuc sayisi = Hesapla(sayi1, sayi2, islem)
        // konsola sonuc sayisi yazdırılsın
        // debug işlemi Main methodunun içerisinde f10 ile girin

        static void Main(string[] args)
        {
            Console.WriteLine("Kısaltma: ");
            string kisaltma = Console.ReadLine();
            // KisaltmayaGoreOyunYazdirIf(kisaltma);
            KisaltmayaGoreOyunYazdirSwitch(kisaltma);
        }

        static void KisaltmayaGoreOyunYazdirSwitch(string? kisaltma)
        {
            switch (kisaltma)
            {
                case "HL":
                    Console.WriteLine("Half Life");
                    break;
                case "CS":
                    Console.WriteLine("Counter Strike");
                    break;
                case "GTA":
                    Console.WriteLine("Grand Theft Auto");
                    break;
                case "RDR":
                    Console.WriteLine("Red Dead Redemption");
                    break;
            }
        }

        static void KisaltmayaGoreOyunYazdirIf(string? kisaltma)
        {
            if(kisaltma == "HL")
            {
                Console.WriteLine("Half Life");
            }
            else if(kisaltma == "CS")
            {
                Console.WriteLine("Counter Strike");
            }
            else if (kisaltma == "GTA")
            {
                Console.WriteLine("Grand Theft Auto");
            }
            else if (kisaltma == "RDR")
            {
                Console.WriteLine("Red Dead Redemption");
            }
        }
    }
}