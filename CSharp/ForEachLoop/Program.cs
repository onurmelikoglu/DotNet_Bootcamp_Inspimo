namespace ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Ankara", "İstanbul", "İzmir", "Adana" };
            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            string[] kelimeler = new string[5];
            kelimeler[0] = "bilgisayar";
            kelimeler[1] = "araba";
            kelimeler[2] = "müzik";
            kelimeler[3] = "köpek";
            kelimeler[4] = "kahve";
            Console.Write("Aranacak kelime: ");
            string aranacak = Console.ReadLine();
            Ara(kelimeler, aranacak);

        }

        static void Ara(string[] kelimeler, string kelime)
        {
            bool bulundu = false;
            foreach (string k in kelimeler)
            {
                if(k == kelime)
                {
                    bulundu = true;
                }
            }
            Console.WriteLine(bulundu ? "Aranan kelime bulundu" : "Aranan kelime bulunamadı");
        }
    }
}
