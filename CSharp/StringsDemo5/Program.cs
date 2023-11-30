namespace StringsDemo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cumle, kelime;
            bool bulundu, sonuc;

            Console.Write("Cümle: (ç: çıkış) ");
            cumle = Console.ReadLine();
            while (cumle.ToLower() != "ç")
            {
                Console.Write("Cümle içerisinde aranacak kelime: ");
                kelime = Console.ReadLine();
                sonuc = CumledeKelimeAra1(cumle, kelime);
                if (sonuc)
                {
                    Console.WriteLine("\"" + cumle + "\" içerisinde \"" + kelime + "\" bulundu.");
                }
                else
                {
                    Console.WriteLine("\"" + cumle + "\" içerisinde \"" + kelime + "\" bulunamadı.");
                }
                Console.Write("Cümle: (ç: çıkış) ");
                cumle = Console.ReadLine();
            }

        }

        //static bool CumledeKelimeAra1(string cumle, string kelime)
        //{
            
        //    bool bulundu = false;

        //    if (cumle.Contains(kelime, StringComparison.OrdinalIgnoreCase))
        //    {
        //        bulundu = true;
        //    }
        //    return bulundu;
        //}

        static bool CumledeKelimeAra1(string cumle, string kelime) => cumle.Contains(kelime, StringComparison.OrdinalIgnoreCase);

        static bool CumledeKelimeAra2(string cumle, string kelime)
        {
            string[] cumleKelimeleri = cumle.Split(' ');
            bool bulundu = false;
            foreach(string cumleKelimesi in cumleKelimeleri)
            {
                // 1. yontem
                // if(cumleKelimesi.ToUpper() == kelime.ToLower())
                // 2. yontem
                if(cumleKelimesi.Equals(kelime, StringComparison.OrdinalIgnoreCase))
                {
                    bulundu = true; break;
                }
            }
            return bulundu;
        }


    }
}
