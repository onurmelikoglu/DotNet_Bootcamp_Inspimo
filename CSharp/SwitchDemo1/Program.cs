namespace SwitchDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                1. Başla
                2. Kullanıcdan Tl cinsinden para girilmesi istenir
                3. kullanıcı para girer
                4. kullanıcıdan para birimi girilmesi istenir( dolar: d, euro: e, Pound: p)
                5. eğer para birimi dolar ise
                
            */

            const decimal dolar = 28.8m;
            const decimal euro = 30m;
            const decimal pound = 32m;
            decimal sonuc;
            string tarih = "15.11.2023";

            Console.Write("TL cinsinden para: ");
            decimal para = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Para birimi: (d: dolar, e: euro, p: pound)");
            string paraBirimi = Console.ReadLine();
            //if(paraBirimi == "d" || paraBirimi == "D")
            //{
            //    sonuc = para / dolar;
            //}
            //else if(paraBirimi == "e" || paraBirimi == "E")
            //{
            //    sonuc = para / euro;
            //}
            //else if( paraBirimi == "p" ||  paraBirimi == "P")
            //{
            //    sonuc = para / pound;
            //}
            switch (paraBirimi)
            {
                case "d":
                case "D":
                    sonuc = para / dolar;
                    break;
                case "e":
                case "E":
                    sonuc = para / euro;
                    break;
                case "p":
                case "P":
                    sonuc = para / pound;
                    break;
                default:
                    sonuc = -1;
                    break;
            }

            if(sonuc == -1) { 
                Console.WriteLine("Geçerli bir para birimi girin (Dolar:d, Euro: e, Pound: p)");
            }
            else
            {
                Console.WriteLine(tarih + ": " + sonuc);
            }
            

            // double vs decimal

            //double sayi1 = 1.1;
            //double sayi2 = sayi1 + 0.1;
            //if(sayi2 == 1.2)
            //{
            //    Console.WriteLine("eşit" + sayi2);
            //}
            //else
            //{
            //    Console.WriteLine("eşit değil" + sayi2);
            //}

            //decimal sayi3 = 1.1m;
            //decimal sayi4 = sayi3 + 0.1m;
            //if (sayi4 == 1.2m)
            //{
            //    Console.WriteLine("eşit" + sayi4);
            //}
            //else
            //{
            //    Console.WriteLine("eşit değil" + sayi4);
            //}
        }
    }
}