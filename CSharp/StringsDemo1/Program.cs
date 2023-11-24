namespace StringsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle(Ç: çıkış)");
            string word = Console.ReadLine();
            int index = 0;
            int wordCount = 0;
            while(word.ToLower() != "ç")
            {
                for(int i = 0; i < word.Length; i++)
                {
                    int space = word.IndexOf(' ', index);
                    if (space == -1) { Console.WriteLine(word.Substring(index)); break; }
                    else { Console.WriteLine(word.Substring(index, space - index)); index = space + 1; wordCount++; }
                }
                Console.WriteLine("Kelime Sayısı: " + ( wordCount + 1 ));
                Console.Write("Cümle (Ç: çıkış)");
                word = Console.ReadLine();
                index = 0;
                wordCount = 0;
            }
        }
    }
}
