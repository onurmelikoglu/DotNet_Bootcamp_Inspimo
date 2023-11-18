namespace FactorialDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz: ");
            int f = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;

            for(int i = f;  i > 0; i--)
            {
                sonuc *= i;
            }
            
            Console.WriteLine($"{f} sayısının faktoriyeli : {sonuc}");
        }
    }
}
