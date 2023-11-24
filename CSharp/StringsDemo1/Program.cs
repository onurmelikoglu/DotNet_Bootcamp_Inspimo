namespace StringsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle(Ç: çıkış)"); 
            string cumle = Console.ReadLine(); 
            int index = 0; 
            while (cumle.ToLower() != "ç") {
                while (index < cumle.Length)
                {
                    int space = cumle.IndexOf(' ', index); 
                    if (space == -1) { Console.WriteLine(cumle.Substring(index)); break; } 
                    else { Console.WriteLine(cumle.Substring(index, space - index)); index = space + 1; } 
                } 
                Console.Write("Cümle (Ç: çıkış)");
                cumle = Console.ReadLine();
                index = 0; 
            }
        }
    }
}
