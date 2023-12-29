using System.Collections;

namespace CollectionMethodsAndProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>()
            {
                5, 2, 3, 4, 1
            };

            List<Kopek> kopekler = new List<Kopek>()
            {
                new Kopek("Angel","İrlanda Seteri", 15, false)
            };

            List<string> oyuncular;

            #region Count
            Console.WriteLine("Sayılar eleman sayısı: " + sayilar.Count); // 6
            Console.WriteLine("Köpekler eleman sayısı: " + kopekler.Count); // 1
            #endregion

            #region Add ve AddRange
            sayilar.Add(7);
            sayilar.Add(6);
            Yazdir(sayilar);

            kopekler.Add(new Kopek("leo", "Sheltie", 8, true));
            Kopek yeniKopek = new Kopek("Luna", "Sheltie", 1, false);
            kopekler.Add(yeniKopek);
            Yazdir(kopekler);

            List<int> yeniSayilar = new List<int>()
            {
                5, 6
            };

            kopekler.AddRange(new List<Kopek>()
            {
                new Kopek("leo2", "Sheltie2", 1, true),
                new Kopek("leo3", "Sheltie3", 2, false)
            });
            Yazdir(kopekler);


            #endregion

            #region IEnumerable, ICollection ve IList
            IEnumerable<string> oyuncuKoleksiyonu = new List<string>()
            {
                "Şener Şen", "Kemal Sunal", "Adile Naşit"
            };
            oyuncular = oyuncuKoleksiyonu.ToList();
            Yazdir(oyuncular);

            ICollection<Kopek> kopekKoleksiyonu = new List<Kopek>()
            {
                new Kopek("Snoopy", "Beagle", 5, true)
            };
            List<Kopek> kopeklerListesi = kopekKoleksiyonu.ToList();
            Yazdir(kopeklerListesi);

            List<Kopek> kopeklerKopya = kopeklerListesi.ToList();
            Yazdir(kopeklerKopya);

            IList<int> sayiKoleksiyonu = new List<int>()
            {
                11, 22, 33
            };
            List<int> sayiListesi = sayiKoleksiyonu.ToList();
            Yazdir(sayiListesi);

            #endregion

            #region Sort, Sum, Average, Minimum ve Maximum
            sayilar.Sort();
            Yazdir(sayilar);

            Console.WriteLine("Sum: " + sayilar.Sum());
            Console.WriteLine("Average: " + sayilar.Average());
            Console.WriteLine("Minimum: " + sayilar.Min());
            Console.WriteLine("Maximum: " + sayilar.Max());
            #endregion

            #region IndexOf, LastIndexOf, ve Contains
            Console.WriteLine("Kemal Sunal index: " + oyuncular.IndexOf("Kemal Sunal"));
            Console.WriteLine("Adile Naşit index: " + oyuncular.IndexOf("adile naşit")); // -1

            if(oyuncular.Contains("Şener Şen"))
                Console.WriteLine("Oyuncu Bulundu");
            #endregion

            #region Insert, Remove, RemoveAt ve clear
            oyuncular.Insert(1, "Münir Özkul");
            Yazdir(oyuncular);

            var yeniKopek2 = new Kopek("Sharky", "Sharkdog", 2, true);
            kopekler.Insert(0, yeniKopek2);
            Yazdir(kopekler);

            kopekler.Remove(yeniKopek2);
            Yazdir(kopekler);

            sayilar.Remove(5);
            Yazdir(sayilar);

            oyuncular.RemoveAt(oyuncular.Count - 1);
            Yazdir(oyuncular);

            // sayilar.Clear();

            #endregion

            #region First, FirstOrDefault, Last ve LastOrDefault
            int ilkSayi, sonSayi;
            string ilkOyuncu, sonOyuncu;
            Kopek ilkKopek, sonKopek;

            // ilkSayi = sayilar.First();
            ilkSayi = sayilar.FirstOrDefault();
            Console.WriteLine("İlk Sayı: " + ilkSayi);

            ilkOyuncu = oyuncular.FirstOrDefault();
            Console.WriteLine("İlk Oyuncu: " + ilkOyuncu);

            sonOyuncu = oyuncular.LastOrDefault();
            Console.WriteLine("Son Oyuncu: " + sonOyuncu);


            #endregion


        }

        static void Yazdir(List<int> sayilar)
        {
            Console.WriteLine("Sayılar: ");
            foreach (int sayi in sayilar) {
                Console.WriteLine(sayi);
            }
        }

        static void Yazdir(List<Kopek> kopekler)
        {
            Console.WriteLine("\nKöpekler");
            foreach(Kopek kopek in kopekler)
            {
                Console.WriteLine(kopek);
            }
        }

        static void Yazdir(List<string> oyuncular)
        {
            Console.WriteLine("\nOyuncular");
            foreach (var oyuncu in oyuncular)
            {
                Console.WriteLine(oyuncu);
            }
        }
    }
}
