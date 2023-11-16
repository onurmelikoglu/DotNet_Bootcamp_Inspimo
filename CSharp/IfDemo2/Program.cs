namespace IfDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //string sonuc = HangisiBuyuk(sayi1 , sayi2);
            // Console.WriteLine(sonuc);

            Console.WriteLine(HangisiBuyuk(3, 2, 1));
            Console.WriteLine(HangisiBuyuk(3, 1, 2));
            Console.WriteLine(HangisiBuyuk(3, 2, 2));

        }

        static string HangisiBuyuk(int sayi1,  int sayi2)
        {
            if (sayi2 > sayi1)
                return $"Sayi 2 ({sayi2})  > Sayı 1 ({sayi1})";
            else if (sayi2 == sayi1)
                return $"Sayi 2 ({sayi2})  == Sayı 1 ({sayi1})";
            else
                return $"Sayi 2 ({sayi2})  < Sayı 1 ({sayi1})";
          
        }

        static string HangisiBuyuk(int sayi1, int sayi2, int sayi3)
        {
            string sonuc = "";
            if(sayi1 > sayi2)
            {
                if(sayi1 > sayi3)
                {
                    sonuc += $"Sayı 1 {sayi1} >";
                    if(sayi2 > sayi3)
                    {
                        sonuc += $"Sayı 2 {sayi2} > Sayı 3 {sayi3}";
                    }
                    else if(sayi3 > sayi2)
                    {
                        sonuc += $"Sayı 3 {sayi3} >  Sayı 2 {sayi2}";
                    }
                    else
                    {
                        sonuc += $"Sayı 2 {sayi3} = Sayı 3 {sayi3}";
                    }
                }
            }
            else
            {
                if(sayi1 > sayi2)
                {
                    sonuc += $"Sayı 1 {sayi1} >  Sayı 2 {sayi2}";
                }
                else if (sayi2 > sayi1)
                {
                    sonuc += $"Sayı 2 {sayi2} >  Sayı 1 {sayi1}";
                }
                else
                {
                    sonuc += $"Sayı 1 {sayi2} =  Sayı 2 {sayi2}";
                }
            }
            return sonuc;
        }

        static string HangisiBuyuk2(int sayi1, int sayi2, int sayi3)
        {
            string sonuc = "";
            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                sonuc += $"Sayı 1 {sayi1} >";
                if (sayi2 > sayi3)
                {
                    sonuc += $"Sayı 2 {sayi2} > Sayı 3 {sayi3}";
                }
                else if (sayi3 > sayi2)
                {
                    sonuc += $"Sayı 3 {sayi3} >  Sayı 2 {sayi2}";
                }
                else
                {
                    sonuc += $"Sayı 2 {sayi3} = Sayı 3 {sayi3}";
                }
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                sonuc += $"Sayı 2 {sayi2} >";
                if (sayi2 > sayi3)
                {
                    sonuc += $"Sayı 1 {sayi1} > Sayı 3 {sayi3}";
                }
                else if (sayi3 > sayi2)
                {
                    sonuc += $"Sayı 3 {sayi3} >  Sayı 1 {sayi1}";
                }
                else
                {
                    sonuc += $"Sayı 1 {sayi1} = Sayı 3 {sayi3}";
                }
            }
            else if (sayi3 > sayi1 && sayi3 > sayi2)
            {
                sonuc += $"Sayı 3 {sayi3} >";
                if (sayi1 > sayi2)
                {
                    sonuc += $"Sayı 1 {sayi1} > Sayı 2 {sayi2}";
                }
                else if (sayi3 > sayi2)
                {
                    sonuc += $"Sayı 2 {sayi2} >  Sayı 1 {sayi1}";
                }
                else
                {
                    sonuc += $"Sayı 1 {sayi1} = Sayı 2 {sayi2}";
                }
            }
            else
            {
                sonuc += $"Sayı 1 {sayi1} = Sayı 2 {sayi2} = Sayı 3 {sayi3}";
            }
            return sonuc;

        }
    }
}