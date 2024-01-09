namespace DictionaryDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> sozluk = new Dictionary<string, string>()
            {
                { "book", "kitap" },
                { "movie", "film" },
                { "song", "şarkı" },
                { "game", "oyun" },
            };

            Console.Write("İngilizce: ");
            string ingilizce = Console.ReadLine();
            string turkce = KelimeAra(ingilizce, sozluk);
            Console.WriteLine("Türkçe: " + ( turkce is null ? "Tükçesi bulunamadı" : turkce) );
        }

        static string KelimeAra(string ingilizceKelime, Dictionary<string, string> sozluk)
        {
            if (sozluk.Keys.Contains(ingilizceKelime))
            {
                return sozluk[ingilizceKelime];
            }
            else
            {
                return null;
            }
        }
    }
}
