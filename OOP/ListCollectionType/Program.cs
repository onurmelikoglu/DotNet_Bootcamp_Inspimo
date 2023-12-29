using ListCollectionType.Models;

namespace ListCollectionType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Type safe (generic ) collections
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("İzmir");

            foreach(var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            Console.WriteLine(sehirler[1]);

            List<int> sayiListesi = new List<int>()
            {
                1, 3, 5, 7, 9
            };

            foreach(int sayi in sayiListesi)
            {
                Console.Write(sayi + " ");
            }

            List<Sehir> sehirListesi = new List<Sehir>()
            {
                new Sehir()
                {
                    PlakaNo = 6,
                    Adi = "Ankara"
                },
                new Sehir(34,"İstanbul")
            };
            Sehir sehirElemani = new Sehir(); 
            sehirListesi.Add(sehirElemani);
            Console.WriteLine();
            sehirListesi.Add(new Sehir()
            {
                PlakaNo = 9,
                Adi = "Aydin"
            });

            for(int i = 0; i < sehirListesi.Count; i++)
            {
                Console.WriteLine("Plaka: " + sehirListesi[i].PlakaNo);
                Console.WriteLine("Adi: " + sehirListesi[i].Adi);
            }

            Sehir indexUzerindenSehir = sehirListesi[2];
            Console.WriteLine("Plaka: " + indexUzerindenSehir.PlakaNo);
        }
    }
}
