namespace StringsDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kelime Gir: ");
            string kelime = Console.ReadLine();
            string sonuc = "";
            string secenek;
            while (kelime.ToUpper() != "Ç")
            {
                Console.Write("Sesli (1), Sessiz (2):");
                secenek = Console.ReadLine();
                if(secenek == "1")
                {
                    sonuc = SeslileriBul(kelime);
                    Console.WriteLine(sonuc == string.Empty ? "Sesli Bulunamadı!": "Sesliler: " + sonuc);
                }
                else
                {
                    sonuc = SessizleriBul(kelime);
                    Console.WriteLine(sonuc == string.Empty ? "Sesli Bulunamadı!" : "Sessizler: " + sonuc);
                }
                Console.Write("Kelime Gir: ");
                kelime = Console.ReadLine();
            }
        }

        // luna -> u, a
        static string SeslileriBul(string deger)
        {
            // if(deger == "") // if deger == null
            //if (string.IsNullOrEmpty(deger))
            //    return "";
            // if(deger == null || deger.Trim() == "")
            if (string.IsNullOrWhiteSpace(deger))
                return "";
            string sonuc = string.Empty;
            string[] sesliler = new string[8] { "a", "e", "ı", "i", "o", "ö", "u", "ü" };
            for(int i = 0; i < deger.Length; i++)
            {
                // 1. yöntem
                //for(int j = 0; j < sesliler.Length; j++)
                //{
                //    if (deger[i].ToString().ToLower() == sesliler[j])
                //    {
                //        sonuc += deger[i] + ", ";
                //    }
                //}

                if (sesliler.Contains(deger[i].ToString().ToLower()))
                {
                    sonuc += deger[i] + ", ";
                }
                    
               //  sonuc = sonuc.TrimEnd(',',' ');

            }
            if (sonuc.Length > 0)
                sonuc = sonuc.Substring(0, sonuc.Length - ", ".Length);
            return sonuc;
        }

        static string SessizleriBul(string deger)
        {
            if (string.IsNullOrWhiteSpace(deger))
                return "";
            string sonuc = string.Empty;
            string ayrac = ", ";
            string[] sesliler = new string[8] { "a", "e", "ı", "i", "o", "ö", "u", "ü" };
            foreach(char harf in deger)
            {
                if (!sesliler.Contains(harf.ToString()) && !sonuc.Contains(harf))
                {
                    sonuc += harf + ayrac;
                }
            }
            sonuc = sonuc.TrimEnd(ayrac.ToCharArray());
            return sonuc;
        }
    }
}
