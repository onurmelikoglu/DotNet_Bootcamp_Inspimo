using System.Runtime.ConstrainedExecution;

namespace IdentityValidationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  1 – TC Kimlik Numaraları 11 karakter olmak zorundadır.
            //  2 – Her hanesi bir rakam olmaldır.
            //  3 – İlk hanesi 0(sıfır) olamaz
            //  4 – 1, 3, 5, 7, 9 basamaklarının toplamının 7 katından, 2, 4, 6, 8 ölümünden kalan sayı(MOD10)  10.basamaktaki sayıyı vermelidir.
            //  5 – İlk 10 hanenin toplamından elde edilen sonucun 10’a bölümünden kalan sayı(MOD10) 11.basamaktaki sayıyı vermelidir.


            Console.WriteLine("TC Kimlik Numaranızı Giriniz:");
            string TCNO = Console.ReadLine();
            bool valid = ValidateTC(TCNO);
            if (valid)
            {
                Console.WriteLine("TC Kimlik Numaranız Geçerlidir.");
            }
            else
            {
                Console.WriteLine("TC Kimlik Numaranız Geçersizdir.");
            }


        }

        static bool ValidateTC(string TCNO)
        {

            int oddSum = 0; // tek basamakların toplamı
            int evenSum = 0; // çift basamakların toplamı
            // int totalSum = 0; // ilk 10 hanenin toplamı

            if (TCNO.Length != 11) return false;
            
            foreach(char c in TCNO) { if(!Char.IsNumber(c)) return false; }

            if(TCNO.Substring(0,1) == "0") return false;

            int[] arrTC = System.Text.RegularExpressions.Regex.Replace(TCNO, "[^0-9]", "").Select(x => (int)Char.GetNumericValue(x)).ToArray();

            for (int i = 0; i < TCNO.Length; i++)
            {
                if (((i + 1) % 2) == 0)
                    if (i + 1 != 10) evenSum += Convert.ToInt32(arrTC[i]); // Çift basamaklar toplamı
                    if (i + 1 != 11) oddSum += Convert.ToInt32(arrTC[i]); // Tek basamaklar toplamı
            }

            int tenthDigit = Convert.ToInt32(TCNO.Substring(9, 1)); // 10. basamak
            int eleventhDigit = Convert.ToInt32(TCNO.Substring(10, 1)); // 11. basamak

            if (tenthDigit != (((oddSum * 7) - evenSum) % 10)) return false;
            if (eleventhDigit != ((arrTC.Sum() - eleventhDigit) % 10)) return false;

            //for (int i = 0; i < 9; i++)
            //{
            //    int digit = int.Parse(tcNo[i].ToString());
            //    if (i % 2 == 0) oddSum += digit; // tek basamaklar
            //    else evenSum += digit; // çift basamaklar
            //}

            //int mod10 = (oddSum * 7 - evenSum) % 10;
            //if (mod10 < 0) mod10 += 10; // negatif ise pozitife çevir
            //int tenthDigit = int.Parse(tcNo[9].ToString()); // 10. basamak
            //if (mod10 != tenthDigit) return false;

            //for (int i = 0; i < 10; i++)
            //{
            //    int digit = int.Parse(tcNo[i].ToString());
            //    totalSum += digit;
            //}
            //mod10 = totalSum % 10;
            //int eleventhDigit = int.Parse(tcNo[10].ToString()); // 11. basamak
            //if (mod10 != eleventhDigit)
            //{
            //    return false;
            //}


            return true;


        }
    }
}
