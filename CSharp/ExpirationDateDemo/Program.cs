using System.Globalization;

namespace ExpirationDateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Son kullanma tarihi giriniz: ");
            string expireDate = Console.ReadLine();
            bool isExpired = ExpirationController(expireDate);
            if (isExpired)
            {
                Console.WriteLine("Son kullanma tarihi geçti");
            }
            else
            {
                Console.WriteLine("Son kullanma tarihi geçmedi");
            }
        }

        static bool ExpirationController(string expireDate)
        {
            bool isExpired = false;
            DateTime today = DateTime.Now.Date;
            DateTime expirationDate = DateTime.Parse(expireDate, new CultureInfo("tr-TR"));
            if (expirationDate < today) isExpired = true;
            return isExpired;
        }   
    }
}
