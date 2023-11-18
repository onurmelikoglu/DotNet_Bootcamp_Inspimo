namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // 1. yöntem:
            for (int i = 1; i <= 21; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            // 2. yöntem:
            for(int i = 2;i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            for(int sayi = 29; sayi >= 1; sayi = sayi -2)
            {
                Console.WriteLine(sayi);
            }


        }
    }
}
