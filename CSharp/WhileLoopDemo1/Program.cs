namespace WhileLoopDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Taban: ");
            long taban = Convert.ToInt64(Console.ReadLine());
            Console.Write("Üs: ");
            long us = long.Parse(Console.ReadLine());
            long sonuc = UsAl(taban, us);
            Console.WriteLine($"{taban} ^ {us} = {sonuc}");

        }

        static long UsAl(long taban, long us)
        {
            long sonuc = 1;
            int i = 1;
            while(i <= us)
            {
                sonuc *= taban;
                i++;
            }
            return sonuc;
        }

    }
}
