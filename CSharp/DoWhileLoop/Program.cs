namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i++);
            //}while (i <= 10);

            //int j = 1;
            //while (j <= 10)
            //{
            //    Console.WriteLine(j++);
            //}

            Console.Write("Başlangıç: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş: ");
            int bitis = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            do
            {
                toplam += baslangic;
                baslangic++;
            }while (baslangic <= bitis);
            Console.WriteLine(toplam);

            char karakter = 'A';
            do
            {
                if (karakter >= 'A' && karakter <= 'Z' || karakter >= 'a' && karakter <= 'z')
                    Console.WriteLine(karakter + " ");
                karakter++;
            } while (karakter <= 'z');
        }
    }
}
