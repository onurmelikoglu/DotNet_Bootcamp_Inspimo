namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SurucuBase surucu1 = new ArabaSurucu()
            {
                Adi = "Çağıl Alsaç",
                EhliyetNo = "1234"
            };

            Araba araba = new Araba(surucu1);
            araba.Sur();

            surucu1 = new KamyonSurucusu()
            {
                Adi = "Onur",
                EhliyetNo = "4321"
            };

            araba = new Araba(surucu1);
            araba.Sur();
        }
    }

    class Araba
    {
        // dependecy injection base sınıflar üzerinden yapılmalı
        private readonly SurucuBase surucu; 

        public Araba(SurucuBase surucu)
        {
            this.surucu = surucu;
        }

        public void Sur()
        {
            Console.WriteLine("Araba " + surucu.Adi + " tarafından sürülüyor");
        }
    }

    abstract class SurucuBase
    {
        public string Adi { get; set; }
        public string EhliyetNo { get; set; }
    }

    class ArabaSurucu : SurucuBase
    {
        
    }

    class KamyonSurucusu : SurucuBase
    {

    }
}
