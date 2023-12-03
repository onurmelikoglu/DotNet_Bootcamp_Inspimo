using DiziDemo.Classes;

namespace DiziDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TekBoyutluDizi sayisalDizi = new TekBoyutluDizi()
            {
                Dizi = new double[] { 8, 1, 5, 6, 1.4 }
            };

            sayisalDizi.Goster(" ");

            Console.WriteLine();

            Console.WriteLine("Eleman Sayisi: " + sayisalDizi.Boyut);
            Console.WriteLine("Eleman Toplami: " + sayisalDizi.Topla());
            Console.WriteLine("Eleman Ortalaması: " + sayisalDizi.OrtalamaHesapla());
            Console.WriteLine("Eleman Min Getir: " + sayisalDizi.MinimumGetir());
            Console.WriteLine("Eleman Max Getir: " + sayisalDizi.MaximumGetir());

        }
    }
}
