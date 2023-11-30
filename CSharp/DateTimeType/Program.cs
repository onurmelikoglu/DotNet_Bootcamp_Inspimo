using System.Globalization;

namespace DateTimeType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "39.25.2023"
            DateTime tarih = DateTime.Now;
            Console.WriteLine(tarih);
            Console.WriteLine(tarih.Date);

            tarih = DateTime.Today;
            Console.WriteLine(tarih);

            DateTime tarih1 = new DateTime(2022, 11, 29);
            Console.WriteLine(tarih1);

            DateTime tarih2 = new DateTime(2022, 11, 29, 21, 49, 55);
            Console.WriteLine(tarih2);

            string tarih2formatlanmis = tarih2.ToString("MM/dd/yyyy HH:mm:ss", new CultureInfo("en-US")); // tr-TR
            Console.WriteLine(tarih2formatlanmis);

            DateTime tarih3 = new DateTime(2022, 11, 21, 18, 35, 41, 567);
            string tarih3yazi = tarih3.Year + "-" + tarih3.Month + "-" + tarih3.Day + " " +
                tarih3.Hour + ":" + tarih3.Minute + ":" + tarih3.Second + ":" + tarih3.Millisecond;
            Console.WriteLine(tarih3yazi);

            Console.WriteLine(tarih3.ToShortDateString());
            Console.WriteLine(tarih3.ToLongDateString());
            Console.WriteLine(tarih3.ToShortTimeString());
            Console.WriteLine(tarih3.ToLongTimeString());

            DateTime tarih4 = DateTime.Parse("23.11.2022", new CultureInfo("tr-TR"));
            Console.WriteLine(tarih4.ToString(new CultureInfo("en-US")));
            Console.WriteLine(tarih4.ToString("yyyy-MM-dd"));

            DateTime simdi = DateTime.Now;
            Console.WriteLine("Bugün: " + simdi);
            Console.WriteLine("Yarın: " + simdi.AddDays(1).ToShortDateString());
            Console.WriteLine("1 hafta öncesi: " + simdi.AddDays(-7).ToShortDateString() + " " + simdi.AddDays(-7).ToLongTimeString());
            Console.WriteLine("6 ay sonrası: " + simdi.AddMonths(6).ToShortDateString());
            Console.WriteLine("12 ay öncesi: " + simdi.AddYears(-1).ToShortDateString());
            Console.WriteLine("Yarım saat öncesi: " + simdi.AddMinutes(-30).ToString(new CultureInfo("tr-TR")));

            DateTime date1 = DateTime.Parse("06.09.2015 01:02:03", new CultureInfo("tr-TR"));
            DateTime date2 = DateTime.Parse("29.04.2010 23:59:58", new CultureInfo("tr-TR"));

            if(date1 > date2) // if(date1.CompareTo(date2)) > 0 eski hali
            {
                Console.WriteLine($"{date1} büyüktür {date2}");
            }
            else if(date1 < date2) // if(date1.CompareTo(date2)) < 0 
            {
                Console.WriteLine($"{date1} küçüktür {date2}");
            }
            else // if(date1.CompareTo(date2)) == 0 
            {
                Console.WriteLine($"{date1} eşittir {date2}");
            }

            long sayisalTarih = DateTime.Now.Ticks;
            Console.WriteLine(sayisalTarih);

            Console.Write("Doğum Tarihi: ");
            string dogumTarihi = Console.ReadLine();
            int yas = YasHesapla2(dogumTarihi);
            Console.WriteLine($"Yaşınız: {yas}");


        }

        static int YasHesapla1(string dogumTarihi)
        {
            DateTime birthDate = DateTime.Parse(dogumTarihi, new CultureInfo("tr-TR"));
            int yas = DateTime.Now.Year - birthDate.Year;
            return yas;
        }

        static int YasHesapla2(string dogumTarihi)
        {
            DateTime birthDate = DateTime.Parse(dogumTarihi, new CultureInfo("tr-TR"));
            TimeSpan tarihFarki = DateTime.Today.Subtract(birthDate);
            int yas = (int)tarihFarki.TotalHours / ( 365 * 24 + 6 );
            return yas;
        }
    }
}
