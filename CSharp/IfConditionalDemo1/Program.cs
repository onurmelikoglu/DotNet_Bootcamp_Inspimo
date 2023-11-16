namespace IfConditionalDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritma örnek 1: Yaş grubu
            // 1. başla 
            // 2. kullanıcıya yaş sorulur
            // 3. kullanıcıdan yaş alınır
            // 4. eğer yaş 0-30 arasında ise genç
            // 5. eğer 31 ile 60 arasında ise orta yaşlı
            // 6. eğer yaş 60'tan büyük ise yaşlı
            // 7. ekrana kullanıcının yaşı ve yaş grubu yazdır
            // 8. bitiş

            string yasSonucu, giris;
            int yas;
            Console.Write("Yas: ");
            giris = Console.ReadLine();
            // yas = Convert.ToInt32(giris);
            yas = int.Parse(giris);
            if(yas >= 0 && yas <= 30)
            {
                yasSonucu = "Genç";
            }
            else if(yas >= 31 && yas <= 60)
            {
                yasSonucu = "Orta Yaşlı";
            }
            else if(yas >=61)
            {
                yasSonucu = "Yaşlı";
            }
            else
            {
                yasSonucu = "Geçersiz Yaş";
            }

            Console.WriteLine("Yaş: " + yas + ", Yaş Grubu: " + yasSonucu);

        }
    }
}