namespace CollectionsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar1 = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };

            List<int> sayilar2 = new List<int>()
            {
                1,2,2,3,3,3,4,4,5
            };

            TekrarlayanSayilariYazdir(sayilar2);
        }

        static void TekrarlayanSayilariYazdir(List<int> sayilar)
        {
            List<int> tekrarlayanSayilar = new List<int>();
            int tekrarlayanSayiAdedi;

            for(int i = 0; i < sayilar.Count; i++)
            {
                tekrarlayanSayiAdedi = 0;
                for(int j = i + 1; j < sayilar.Count; j++)
                {
                    if (sayilar[i] == sayilar[j]) 
                        tekrarlayanSayiAdedi++;
                }

                if(tekrarlayanSayiAdedi > 0)
                {
                    tekrarlayanSayilar.Add(sayilar[i]);
                }
                
            }

            IEnumerable<int> tekilTekrarlayanSayilar = tekrarlayanSayilar.Distinct();
            tekrarlayanSayiAdedi = tekilTekrarlayanSayilar.Count(); 

            if (tekrarlayanSayiAdedi == 0)
            {
                Console.WriteLine("Sayılar içerisinde tekrarlayan sayı bulunamadı.");
            }
            else
            {
                Console.WriteLine($"Sayılar içerisinde {tekrarlayanSayiAdedi} adet tekrarlayan sayı bulundu");
                Yazdir(tekilTekrarlayanSayilar.ToList());
            }
        }

        static void Yazdir(List<int> sayilar)
        {
            // 1. yöntem
            //string sonuc = "";
            //foreach(int sayi in sayilar)
            //{
            //    sonuc += sayi + ", ";
            //}
            //sonuc = sonuc.TrimEnd(',',' ');
            // 2. yöntem
            string sonuc = string.Join(", ", sayilar);
            Console.WriteLine(sonuc);
        }
    }
}
