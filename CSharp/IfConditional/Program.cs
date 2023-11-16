namespace IfConditional
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Assignment operator : =
            // Arithmetic operators : +, -, *, /, %
            // Relational operators : ==, !=, >,>=, <=
            // Logical operators: !(not), && (and), || (or)

            /* Önermeler: 1 = true, 0 = false
            p   q   and (&&)    çarpma
            1   1   1
            1   0   0
            0   1   0
            0   0   0

            p   q   or (||)     toplama
            1   1   1
            1   0   1
            0   1   1
            0   0   0

            */
            

            int sayi = 10;
            Console.WriteLine("Sayı : " + sayi);

            if( sayi == 10 )
            {
                Console.WriteLine("Doğru");
            }

            sayi = 20;
            if( sayi == 10)
            {
                Console.Write("Sayı ");
                Console.WriteLine("On");
            }
            else
            {
                Console.WriteLine("On Değil.");
            }

            if(!(sayi == 10)) // sayi != 10
                Console.WriteLine("Sayı On Değil.");
            else // sayi == 10
                Console.WriteLine("On");

            if(sayi >= 10 && sayi < 20)
            {
                Console.WriteLine("sayı 10 ile 20 arasındadır");
            }
            else if(sayi >= 20 && sayi < 30)
            {
                Console.WriteLine("sayı 20 ile 30 arasındadır");
            }
            else if(sayi >= 30 && sayi < 40)
            {
                Console.WriteLine("sayı 30 ile 40 arasındadır");
            }
            else // sayi < 10 || sayi >= 40
                Console.WriteLine("sayı aralık dışındadır");

        }
    }
}