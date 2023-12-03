namespace DiziDemo.Classes
{
    class TekBoyutluDizi
    {
        public double[] Dizi { get; set; }
        public int Boyut => Dizi.Length;
        public void Goster(string ayrac = "\n")
        {
            Console.WriteLine("Dizi elemanları: ");
            foreach (double eleman in Dizi)
            {
                Console.Write(eleman + ayrac);
            }
        }

        public double Topla() => Dizi.Sum();
        public double OrtalamaHesapla() => Dizi.Average();
        public double MinimumGetir() => Dizi.Min();
        public double MaximumGetir() => Dizi.Max();

    }
}
