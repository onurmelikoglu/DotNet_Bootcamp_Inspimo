namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] test1 = { 4, 2, 3, 5, 1 };
            decimal[] test2 = { 4, 4, 3, 3, 1 };
            decimal[] test3 = { 6, 3, 2, 5, 1, 9, 8, 4, 7 };
            decimal[] test4 = { 7, 9, 8, 5, 5, 3, 2, 4, 6 };
            Yazdir(BubbleSort(test1));
            Yazdir(BubbleSort(test2));
            Yazdir(BubbleSort(test3));
            Yazdir(BubbleSort(test4));
            Array.Sort(test1);
            Yazdir(test1);
        }

        static void Yazdir(decimal[] veriKumesi) 
        {
            string sonuc = "";
            foreach(var veri in veriKumesi)
            {
                sonuc += veri + ", ";
            }
            sonuc = sonuc.TrimEnd(", ".ToCharArray());
            Console.WriteLine(sonuc);
        }

        static decimal[] BubbleSort(decimal[] veriKumesi)
        {
            decimal[] siralanmisVeriKumesi = new decimal[veriKumesi.Length];
            // 1. yöntem
            for(int i = 0; i < veriKumesi.Length; i++)
            {
                siralanmisVeriKumesi[i] = veriKumesi[i];
            }
            // 2. yöntem
            siralanmisVeriKumesi = veriKumesi.ToArray();

            decimal gecici;
            bool degistirildiMi = true;
            for(int i = 0; i < siralanmisVeriKumesi.Length; i++)
            {
                degistirildiMi = false;
                for(int j = 0; j < siralanmisVeriKumesi.Length - 1; j++)
                {
                    if(siralanmisVeriKumesi[j] > siralanmisVeriKumesi[j + 1])
                    {
                        gecici = siralanmisVeriKumesi[j];
                        siralanmisVeriKumesi[j] = siralanmisVeriKumesi[j + 1];
                        siralanmisVeriKumesi[j + 1] = gecici;
                        degistirildiMi = true;
                    } 
                }
            }

            return siralanmisVeriKumesi;
        }

    }
}
