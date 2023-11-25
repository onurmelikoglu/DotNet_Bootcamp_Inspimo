namespace StringsDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ÇAĞIL ALSAÇ -> Çağıl Alsaç
            // cağıl alsaç -> Çağıl Alsaç
            // çAğIl AlSaÇ -> Çağıl Alsaç

            string giris,cikti, sonuc="";
            Console.Write("Kelime: ");
            giris = Console.ReadLine();
            if(giris == "")
            {
                Console.WriteLine("Kelime en az 2 harf olmalıdır!");
            }
            else
            {
                string[] kelimeler = KelimelereParcala(giris);
                foreach(string kelime in kelimeler)
                {
                    cikti = IlkBuyukDigerleriKucuk(kelime);
                    sonuc += cikti + " ";
                }
                sonuc = sonuc.TrimEnd();
                Console.WriteLine(sonuc);
            }
            

        }

        static string IlkBuyukDigerleriKucuk(string kelime)
        {
            if (kelime.Length >= 2)
                return kelime.Substring(0, 1).ToUpper() + kelime.Substring(1).ToLower();
            string test = string.Empty;
            return test; // ""
        }

        static string[] KelimelereParcala(string cumle) => cumle.Split(' ');
    }
}
