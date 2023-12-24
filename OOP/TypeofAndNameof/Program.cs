namespace TypeofAndNameof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap = new Kitap("123456","Sabahattin Ali", "Kürk Montolu Madonna", 1998);

            Console.WriteLine("Kitap:\n" + kitap);
            Console.WriteLine("\nnameof:\n" + nameof(Kitap));
            Console.WriteLine("\ntypeof:\n" + typeof(Kitap));
            Console.WriteLine("\nType: " + kitap.GetType());
        }
    }

    class Kitap
    {
        public string ISBN { get; set; }
        public string Yazari { get; set; }
        public string Adi { get; set; }
        public short Yili { get; set; }

        public Kitap(string isbn, string yazari, string adi, short yili)
        {
            ISBN = isbn;
            Yazari = yazari;
            Adi = adi;
            Yili = yili;
        }

        public override string ToString()
        {
            return "ISBN: " + ISBN + "\nAdı: " + Adi + "\nYili: " + Yili + "\nYazarı: " + Yazari;
        }
    }
}
