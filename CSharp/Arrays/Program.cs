namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciler;
            ogrenciler = new string[3];

            ogrenciler[0] = "Çağıl";
            ogrenciler[1] = "Leo";
            ogrenciler[2] = "Luna";
            Console.WriteLine(ogrenciler[0]); // Çağıl

            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            // ogrenciler[3] = "Ali"; // index out of bound hatası fırlatır

            ogrenciler = new string[4];

            ogrenciler[0] = "Çağıl";
            ogrenciler[1] = "Leo";
            ogrenciler[2] = "Luna";
            ogrenciler[3] = "Ali";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                // Console.WriteLine(ogrenciler[i]);
                Console.WriteLine((i + 1) + ". öğrenci: " + ogrenciler[i]);
            }

            decimal[] ondalikSayilar = new decimal[]
            {
                1.1m, 2.2m, 3.3m
            };

            for (int i = 0; i < ondalikSayilar.Length; i++)
            {
                // Console.WriteLine(ogrenciler[i]);
                Console.WriteLine(ondalikSayilar[i]);
            }

            char[] karakterler = { 'O', 'N', 'U', 'R' };
            for(int i = 0; i < karakterler.Length; i++)
            {
                Console.Write(karakterler[i]);
            }

            string isim = "ONUR";
            Console.WriteLine(isim);

            double[] sayilar = new double[3]
            {
                1.5,
                2.5,
                3.5
            };


            double toplam = 0;
            int index = 0;

            while(index < sayilar.Length)
            {
                toplam += sayilar[index];
                index++;
            }

            Console.WriteLine("Toplam: " + toplam + " (" + sayilar.Sum() + ")");

        }
    }
}
