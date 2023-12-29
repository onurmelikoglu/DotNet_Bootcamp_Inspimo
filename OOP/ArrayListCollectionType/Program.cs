using System.Collections;

namespace ArrayListCollectionType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[3];
            isimler[0] = "Angel";
            isimler[1] = "Leo";
            isimler[2] = "Luna";

            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }

            ArrayList isimListesi = new ArrayList()
            {
                "Angel",
                "Leo",
                "Luna",
                1
            };

            foreach(var isim in isimListesi)
            {
                Console.WriteLine(isim);
            }

            isimListesi.Add(true);

            Console.WriteLine(isimListesi[4]); // true
        }
    }
}
