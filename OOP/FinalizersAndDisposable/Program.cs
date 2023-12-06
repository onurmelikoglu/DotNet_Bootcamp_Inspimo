using System.Globalization;

namespace FinalizersAndDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kategori kategori1 = new Kategori()
            {
                Aciklamasi = "Laptop, desktop ve sunucu",
                Adi = "Bilgisayar",
                Id = 1
            };

            Kategori kategori2 = new Kategori()
            {
                Aciklamasi = "Laptop, desktop ve sunucu",
                Adi = "Bilgisayar",
                Id = 1
            };

            Product product = new Product();
            product.Name = "HP";
            product.UnitPrice = 75000;
            product.StockAmount = 100;

            Console.WriteLine($"Product: {product.Name}\n{product.UnitPrice.ToString("C2", new CultureInfo("en-US"))}\n{product.StockAmount}");

            product.Dispose();
        }
    }

    class Kategori
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Aciklamasi { get; set; }

        public Kategori() // constructor
        {
            Console.WriteLine("Kategori constructor'ı çalıştırıldı. ");
        }

        ~Kategori() // finalizer
        {
            // obje temizleme kodları yazılır
            Console.WriteLine("Kategori finalizer'ı çalıştırıldı");
        }

        

    }

    class Product : IDisposable
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int StockAmount { get; set; }

        bool isDisposed = false;

        public void Dispose()
        {
            if (!isDisposed)
            {
                GC.SuppressFinalize(this);
                isDisposed = true;
            }
                
        }
    }

}
