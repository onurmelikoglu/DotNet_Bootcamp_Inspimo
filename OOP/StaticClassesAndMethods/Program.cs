namespace StaticClassesAndMethods
{
    internal class Program
    {
        // static StringUtil stringutil;
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string input = Console.ReadLine();
            Display(input);

            if (StringUtil.IsEmpty(input))
            {
                Console.WriteLine("Empty string");
            }
            else
            {
                Console.WriteLine("Not empty string");
            }

            Config.ConnectionString = "MS SQL Server Connection String";
            Config.SetDate(DateTime.Now);
            Console.WriteLine(Config.ConnectionString);
            Config.ConnectionString = "Oracle Connection String";
            Console.WriteLine(Config.ConnectionString);

            string ad = "Çağıl";
            int l = ad.Length;
            bool r = string.IsNullOrEmpty(ad);

            Console.Write("Sayı: ");
            string giris = Console.ReadLine();
            double sayi;
            // bool result = StringUtil.IsNumeric(giris, out sayi);
            bool result = StringUtil.IsNumeric(giris, out sayi, "en-US");

            if (result)
            {
                Console.WriteLine(sayi + " Sayılsal");
            }
            else
            {
                Console.WriteLine("Sayılsal değil");
            }
        }



        static void Display(string value)
        {
            StringUtil stringUtil = new StringUtil();
            DisplayOperations displayOperations = new DisplayOperations();
            displayOperations.Display("String value: " + value);
            displayOperations.Display("String length: " + stringUtil.GetLength(value));
        }
    }
}
