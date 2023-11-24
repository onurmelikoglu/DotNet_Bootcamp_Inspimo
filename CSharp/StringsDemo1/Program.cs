namespace StringsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle(Ç: çıkış)");
            string cumle = Console.ReadLine();
            int index = 0;
            int wordCount = 0;
            while( cumle.ToLower() != "ç")
            {
                for(int i = 0; i < cumle.Length; i++)
                {
                    int space = cumle.IndexOf(' ', i);
                    if (space == -1) { Console.WriteLine(cumle.Substring(i)); break; }
                    else { Console.WriteLine(cumle.Substring(i, space - i)); i = space + 1; wordCount++; }
                }
                Console.WriteLine("Kelime Sayısı: " + ( wordCount + 1 ));
                Console.Write("Cümle (Ç: çıkış)");
                cumle = Console.ReadLine();
                wordCount = 0;
            }
        }
    }
}
