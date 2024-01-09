
namespace DictionaryDemo2
{
    internal class Program
    {

        static Dictionary<string, string> harfSozlugu = new Dictionary<string, string>()
        {
            { "Ö", "O" },
            { "Ç", "C" },
            { "Ş", "S" },
            { "Ğ", "G" },
            { "Ü", "U" },
            { "ö", "o" },
            { "ç", "c" },
            { "ş", "s" },
            { "ğ", "g" },
            { "ü", "u" },
            { "İ", "I" },
            { "ı", "i" },
        };

        static void Main(string[] args)
        {
            string giris, sonuc;
            Console.Write("Türkçe: ");
            giris = Console.ReadLine();

            sonuc = ingilizceyeDonustur(giris);

            Console.WriteLine("İngilizce: " + sonuc);
        }

        private static string ingilizceyeDonustur(string? turkceCumle)
        {
            string ingilizceCumle = String.Empty;
            foreach(char harf in turkceCumle)
            {
                if (harfSozlugu.ContainsKey(harf.ToString()))
                {
                    ingilizceCumle += harfSozlugu[harf.ToString()];
                }
                else
                {
                    ingilizceCumle += harf.ToString();
                }
            }

            return ingilizceCumle;

        }
    }
}
