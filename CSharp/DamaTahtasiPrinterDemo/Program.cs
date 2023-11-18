namespace CheckerboardPatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Tek ve çift durumuna göre bir yıldız ve bir boşluk çizer
                    if ((i + j) % 2 == 0) Console.Write("*");
                    else Console.Write(" "); 
                }
                // Yeni satıra geçer
                Console.WriteLine();
            }

        }
    }
}
