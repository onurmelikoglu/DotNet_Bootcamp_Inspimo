namespace ForLoopDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1 dışında pozitif tam sayı: ");
            int sayi = int.Parse(Console.ReadLine());
            // Console.WriteLine(AsalMi1(sayi));
            // Console.WriteLine(AsalMi2(sayi));
             Console.WriteLine(AsalMi3(sayi));
        }

        static string AsalMi1(int sayi)
        {
            bool asalMi = true;
            for (int i = 2; i < sayi; i++)
            {
                if(sayi % i == 0) // asal değil
                {
                    asalMi = false;
                }
            }

            return asalMi ? "Asal" : "Asal değil";
        }

        static string AsalMi2(int sayi)
        {
            bool asalMi = true;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0) // asal değil
                {
                    asalMi = false;
                    break;
                }
            }

            return asalMi ? "Asal" : "Asal değil";
        }

        static string AsalMi3(int sayi)
        {
            bool asalMi = true; // flag
            for (int i = 2; i < sayi && asalMi == true; i++)
            {
                if (sayi % i == 0) // asal değil
                {
                    asalMi = false;
                }
            }

            return asalMi ? "Asal" : "Asal değil";
        }


    }
}
