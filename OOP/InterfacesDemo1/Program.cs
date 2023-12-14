using InterfacesDemo1.Classes;
using InterfacesDemo1.Classes.Base;

namespace InterfacesDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba()
            {
                BeygirGucu = 184,
                DireksiyonSoldaMi = true,
                KasaTipi = KasaTipi.Sedan,
                Marka = "Mini",
                Model = "Cooper S",
                MotorHacmi = 123,
                TekerlekSayisi = 4,
                YakitTipi = YakitTipi.Benzin
            };

            Console.WriteLine(araba1.AracBilgileriniGetir("\n"));

            IArac kamyon1 = new Kamyon();
            kamyon1.Marka = "Mercedes";
            kamyon1.Model = "Arctos";
            kamyon1.BeygirGucu = 120;
            kamyon1.YakitTipi = YakitTipi.Dizel;
            kamyon1.MotorHacmi = 1000;
            kamyon1.TekerlekSayisi = 10;
            (kamyon1 as Kamyon).DireksiyonSoldaMi = true;

            Console.WriteLine(kamyon1.AracBilgileriniGetir("\n"));

            IArac[] araclar = new IArac[3];
            araclar[0] = araba1;
            araclar[1] = kamyon1;
            araclar[2] = new Motorsiklet()
            {
                BeygirGucu = 175,
                Marka = "Yamaha",
                Model = "Z1",
                MotorHacmi = 250,
                TekerlekSayisi = 2,
                YakitTipi = YakitTipi.Elektrik
            };

            IArac arac;
            for(int i = 0; i < araclar.Length; i++)
            {
                arac = araclar[i];
                if(arac is Araba)
                {
                    Console.WriteLine("\nAraba: ");
                    Console.WriteLine($"Marka: {arac.Marka}\n");
                    Console.WriteLine($"Direksiyon: {((arac as Araba).DireksiyonSoldaMi ? "Solda" : "Sağda")}\n");
                    Console.WriteLine($"Kasa Tipi: {((arac as Araba).KasaTipi)}\n");
                }
                else if( arac is Kamyon)
                {
                    Console.WriteLine("\nKamyon: ");
                    Console.WriteLine($"Marka: {arac.Marka}\n");
                    Console.WriteLine($"Direksiyon: {((arac as Kamyon).DireksiyonSoldaMi ? "Solda" : "Sağda")}\n");
                }
                else
                {
                    Console.WriteLine("\nMotorsiklet: ");
                    Console.WriteLine($"Marka: {arac.Marka}\n");
                }
            }
        }
    }
}
