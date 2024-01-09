namespace DictionaryCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<byte,string> sehirler = new Dictionary<byte, string>();

            sehirler.Add(6,"Ankara");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(35, "İzmir");

            foreach(KeyValuePair<byte, string> sehir in sehirler)
            {
                Console.WriteLine($"Plaka: {sehir.Key}, Adı: {sehir.Value}");
            }

            Console.WriteLine(sehirler[34]); // istanbul

            if (sehirler.ContainsKey(7))
            {
                Console.WriteLine("Antalya bulundu");
            }
            else
            {
                Console.WriteLine("Antalya bulunamadı");
            }

            if (sehirler.ContainsValue("İzmir"))
            {
                Console.WriteLine("İzmir bulundu");
            }
            else
            {
                Console.WriteLine("İzmir bulunamadı");
            }

            Console.WriteLine("Şehir sayısı: " + sehirler.Count);

            Dictionary<string, Ulke> ulkeler = new Dictionary<string, Ulke>()
            {
                { 
                    "TR", new Ulke(){ 
                        Adi= "Türkiye",
                        Nufusu = 84780000,
                        Yuzolcumu = 783562 
                    }
                },
                {
                    "ABD", new Ulke(){
                        Adi= "Amerika",
                        Nufusu = 331980000,
                        Yuzolcumu = 9834000.5M
                    }
                },
            };

            string ilkUlkeAnahtari = ulkeler.Keys.FirstOrDefault();
            Ulke ulke = ulkeler[ilkUlkeAnahtari];
            Console.WriteLine("İlk Ülke: " + ulke.Adi);
            foreach(var u in ulkeler)
            {
                Console.WriteLine("Ülke adı: " + u.Value.Adi + "\nNüfusu: " + u.Value.Nufusu.ToString("N0"));
            }



        }
    }

    class Ulke
    {
        public string Adi { get; set; }
        public int Nufusu { get; set; }
        public decimal Yuzolcumu { get; set; }
    }
}
