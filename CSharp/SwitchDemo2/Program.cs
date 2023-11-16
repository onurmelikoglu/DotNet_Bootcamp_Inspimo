namespace SwitchDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fiyat aralığını görmek istediğiniz bilgisayar tipi giriniz ( d veya D: dizüstü, m veya M: masaüstü, s veya S: Sunucu ) ");
            string giris = Console.ReadLine(); 

            if(giris == "d" || giris == "D" || giris == "m" || giris == "M" || giris == "s" || giris == "S")
            {
                BilgisayarTipi bilgisayarTipi;
                //if (giris == "d" || giris == "D")
                //{
                //    bilgisayarTipi = BilgisayarTipi.Dizüstü;
                //}
                //else if (giris == "m" || giris == "M")
                //{
                //    bilgisayarTipi = BilgisayarTipi.Masaüstü;
                //}
                //else
                //{
                //    bilgisayarTipi = BilgisayarTipi.Sunucu;
                //}

                bilgisayarTipi = giris == "d" || giris == "D" ?
                    BilgisayarTipi.Dizüstü : giris == "m" || giris == "M" ?
                    BilgisayarTipi.Masaüstü : BilgisayarTipi.Sunucu;


                switch (bilgisayarTipi)
                {
                    case BilgisayarTipi.Dizüstü:
                        Console.WriteLine(BilgisayarTipi.Dizüstü + "için fiyat aralığı: 30000 TL ile 150000 TL arasındadır. ");
                        break;
                    case BilgisayarTipi.Masaüstü:
                        Console.WriteLine(BilgisayarTipi.Masaüstü + " için fiyat aralığı : 25000 TL ile 125000 TL arasındadır");
                        break;
                    default: // Sunucu
                        Console.WriteLine(BilgisayarTipi.Sunucu + " için fiyat aralığı : 70000 TL ile 200000 TL arasındadır");
                        break;
                }
            } 
            else
            {
                Console.WriteLine("Girdiğiniz pc tipi uygun deildir");
            }

             
            


        }
    }

    enum BilgisayarTipi { 
        Dizüstü, 
        Masaüstü,
        Sunucu
    }
}