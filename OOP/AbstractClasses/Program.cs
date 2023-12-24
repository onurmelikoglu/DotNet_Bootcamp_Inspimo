using AbstractClasses.Bases;
using System.Globalization;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abstract sınıfından yeni bir nesne üretemeyiz!!
            //RecordBase record = new RecordBase()
            //{
            //    Id = 1,
            //    Guid = "10482db5-4a4f-4081-ab25-e543f5fbd2e7"
            //};

            //Console.WriteLine("ID: " + record.Id + "\nGuid" + record.Guid);

            Product product1 = new Product()
            {
                Id = 1,
                Name = "iPhone 15",
                UnitPrice = 100000,
                StockAmount  = 50,
                Guid = Guid.NewGuid().ToString(),
            };
            Console.WriteLine("ID: " + product1.Id + "\nName: " + product1.Name + "\nUnit Price: " + product1.UnitPrice.ToString("C2", new CultureInfo("tr-TR")) + "\nStock Amount: " + product1.StockAmount + "\nGuid: " + product1.Guid);

            Store store1 = new Store() 
            {
                Id = 2,
                Name = "Vatan",
                Country = "Türkiye",
                City = "İstanbul",
                Guid = Guid.NewGuid().ToString(),
            };

            Console.WriteLine($"ID: {store1.Id}");
            Console.WriteLine($"Guid: {store1.Guid}");
            Console.WriteLine($"Name: {store1.Name}");
            Console.WriteLine($"Country: {store1.Country}");
            Console.WriteLine($"City: {store1.City}");

        }
    }
}
