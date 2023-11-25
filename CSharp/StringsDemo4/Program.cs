namespace StringsDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string turkce = "Benim adım Çağıl Alsaç.";
            string ingilizce = IngilizceyeDonustur1(turkce);
            Console.WriteLine(ingilizce);
        }

        static string IngilizceyeDonustur1(string turkceDeger)
        {
            if(string.IsNullOrEmpty(turkceDeger))
                return string.Empty;
            string sonuc = "";
            bool bulundu;
            string[,] turkceIngilizceHarfler = new string[,]
            {
                {"Ç", "C" },
                {"Ö", "O" },
                {"İ", "I" },
                {"Ş", "S" },
                {"Ü", "U" },
                {"Ğ", "G" },
                {"ç", "c" },
                {"ö", "o" },
                {"ı", "i" },
                {"ş", "s" },
                {"ü", "u" },
                {"ğ", "g" },
            };
            foreach (char harf in turkceDeger)
            {
                bulundu = false;
                for (int satir = 0; satir <= turkceIngilizceHarfler.GetUpperBound(0); satir++)
                {
                    if(harf.ToString() == turkceIngilizceHarfler[satir, 0])
                    {
                        sonuc += turkceIngilizceHarfler[satir, 1];
                        bulundu = true;
                    }
                }
                if (!bulundu)
                    sonuc += harf;
            }
            return sonuc;
        }

        static string IngilizceyeDonustur2(string turkceDeger)
        {
            return turkceDeger.Replace("Ç", "C")
                            .Replace("Ç", "C")
                            .Replace("Ö", "O")
                            .Replace("İ", "I")
                            .Replace("Ş", "S")
                            .Replace("Ü", "U")
                            .Replace("Ğ", "G")
                            .Replace("ç", "c")
                            .Replace("ö", "o")
                            .Replace("ı", "i")
                            .Replace("ş", "s")
                            .Replace("ü", "u")
                            .Replace("ğ", "g");
        }
    }
}
