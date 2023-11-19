namespace ForEachDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorular = new string[]
            {
                "Kıskanç mısın? (1: hayır, 2: evet)",
                "Aşk mı para mı? (1: aşk, 2: para)",
                "Köpek mi Kedi mi? (1: köpek, 2: kedi)",
                "Marka takıntılı mısın? (1: hayır, 2: evet)",
                "Zeka mı tip mi? (1: zeka, 2: tip)",
            };

            int[] cevaplar = new int[sorular.Length];
            for (int i = 0; i < cevaplar.Length; i++)
            {
                Console.Write(sorular[i]);
                cevaplar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int yuzde = 0;
            foreach(int cevap in cevaplar)
            {
                if(cevap == 1) yuzde += 20;
                else if(cevap == 2) yuzde += 5;
            }
            if (yuzde > 70) Console.WriteLine("Ruh eşini buldun.");
            else if (yuzde > 30 && yuzde < 70) Console.WriteLine("Şans tanınabilir");
            else Console.WriteLine("Kaç kurtar kendini");

        }
    }
}
