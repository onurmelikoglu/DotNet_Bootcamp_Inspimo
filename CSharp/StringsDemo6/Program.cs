
using System.Globalization;

namespace StringsDemo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = SehirleriDoldur();
            Console.Write("Şehir: ");
            string sehir = Console.ReadLine();
            Console.Write("Arama (1. baslayan, 2: içeren): ");
            string arama = Console.ReadLine();
            string[] bulunanSehirler = SehirAra(sehirler, sehir, arama);
            SehirleriYazdir(bulunanSehirler);
        }

        static void SehirleriYazdir(string[] bulunanSehirler)
        {
            if(bulunanSehirler.Length == 0)
            {
                Console.WriteLine("Şehir Bulunamadı");
            }
            else
            {
                Console.WriteLine("Bulunan sehirler: ");
                foreach (string sehir in bulunanSehirler)
                {
                    Console.WriteLine(sehir);
                }
            }
            
        }

        static string[] SehirAra(string[] sehirler, string sehir, string arama)
        {
            string[] sonucSehirler;
            int sonucSayisi = 0;
            // if((arama == "1" && s.StartsWith(sehir, StringComparison.CurrentCultureIgnoreCase)) 
            foreach (string s in sehirler)
            {
                if((arama == "1" && s.StartsWith(sehir, true, new CultureInfo("tr-TR")) 
                    || ( arama == "2" && s.Contains(sehir, StringComparison.CurrentCultureIgnoreCase))))
                {
                    sonucSayisi++;
                }
            }
            sonucSehirler = new string[sonucSayisi];
            int j = 0;
            for(int i = 0; i < sehirler.Length; i++)
            {
                if ((arama == "1" && sehirler[i].StartsWith(sehir, true, new CultureInfo("tr-TR")) 
                    || (arama == "2" && sehirler[i].Contains(sehir, StringComparison.CurrentCultureIgnoreCase))))
                {
                    sonucSehirler[j++] = sehirler[i];
                }
            }
            return sonucSehirler;
        }

        static string[] SehirleriDoldur()
        {
            return new string[]
            {
                "Ankara",
                "İstanbul",
                "İzmir",
                "Eskişehir"
            };
        }
    }
}
