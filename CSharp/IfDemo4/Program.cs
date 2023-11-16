namespace IfDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ogrenciAdSoyad = OgrenciGiris();
            double vize1, vize2, final, ortalama;
            string sonuc = "";
            if(ogrenciAdSoyad != "")
            {
                vize1 = NotGiris("Vize 1");
                if(vize1 >= 0 &&  vize1 <= 100)
                {
                    vize2 = NotGiris("Vize 2");
                    if(vize2 >= 0 && vize2 <= 100)
                    {
                        final = NotGiris("Final");
                        if(final >= 0 && final <= 100)
                        {
                            ortalama = OrtalamaHesapla(vize1, vize2, final);
                            if(ortalama >= 60)
                            {
                                sonuc = ogrenciAdSoyad + " geçti";
                            }
                            else
                            {
                                sonuc = ogrenciAdSoyad + " kaldı";
                            }
                        }
                        else
                        {
                            sonuc = "final 0 ile 100 aralığında olmalıdır";
                        }
                    }
                    else
                    {
                        sonuc = "vize2 0 ile 100 aralığında olmalıdır";
                    }
                }
                else
                {
                    sonuc = "vize1 0 ile 100 aralığında olmalıdır";
                }
            }
            else
            {
                sonuc = "Öğrenci ad soyad giriniz";
            }
            Console.WriteLine(sonuc);
        }

        static double OrtalamaHesapla(double vize1, double vize2, double final)
        {
            const double vize1carpan = 0.2;
            const double vize2carpan = 0.2;
            const double finalcarpan = 0.6;
            return vize1 * vize1carpan + vize2 * vize2carpan + final * finalcarpan;

        }

        static double NotGiris(string mesaj)
        {
            Console.Write(mesaj + ": ");
            // Convert.ToDouble(Console.ReadLine());
            return double.Parse(Console.ReadLine());
        }

        static string OgrenciGiris()
        {
            Console.Write("Öğrenic ad soyad: ");
            return Console.ReadLine();
        }
    }
}