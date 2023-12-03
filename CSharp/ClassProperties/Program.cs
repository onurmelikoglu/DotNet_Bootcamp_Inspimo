using System.Globalization;

namespace ClassProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.Marka = "Mini";
            araba1.Model = "Cooper S";
            araba1.TrafigeCikisTarihi = DateTime.Parse("02.12.2022");
            araba1.BeygirGucu = 184;
            araba1.KapiSayisi = 3;
            araba1.MotorHacmi = 1600;
            string araba1Text = "";
            araba1Text += $"Marka: {araba1.Marka} \n";
            araba1Text += $"Model: {araba1.Model} \n";
            araba1Text += $"Turu: {araba1.Turu} ({(int)araba1.Turu})\n";
            araba1Text += $"Trafiğe Çıkış Tarihi: {araba1.TrafigeCikisTarihi.ToShortDateString()} \n";
            araba1Text += $"Beygir Gücü: {araba1.BeygirGucu} HP\n";
            araba1Text += $"Model: {araba1.KapiSayisi} kapı\n";
            araba1Text += $"Motor Hacmi: {araba1.MotorHacmi} cm3\n";

            Console.WriteLine(araba1Text);

            Araba araba2 = new Araba()
            {
                Marka = "Fiat",
                Model = "Doblo",
                Turu = ArabaTipi.Ticari,
                TrafigeCikisTarihi = new DateTime(2023, 2, 1),
                BeygirGucu = 68,
                KapiSayisi = 5,
                MotorHacmi = 1300
            };

            Console.WriteLine($"Marka: {araba2.Marka}\n Model: {araba2.MotorHacmi}");

            CultureInfo cultureInfo = new CultureInfo("tr");
            string dateFormat = "dd.MM.yyyy";
            Bilgisayar bilgisayar = new Bilgisayar()
            {
                Id = 1,
                Marka = "ASUS",
                Model = "ROG",
                Tipi = BilgisayarTipi.Dizüstü,
                GHz = 3.33,
                Hafiza = 32,
                EkranBoyutu = 27,
                SuSogutmaliMi = true,
                UretimTarihi = new DateTime(2020, 5, 19)
            };
            Console.WriteLine("*** Bilgisayar Bilgileri ***");
            Console.WriteLine("Id: " + bilgisayar.Id);
            Console.WriteLine("Marka: " + bilgisayar.Marka);
            Console.WriteLine("Model: " + bilgisayar.Model);
            Console.WriteLine("Tipi: " + bilgisayar.Tipi + " (" + (int)bilgisayar.Tipi + ")");
            Console.WriteLine("GHz: " + bilgisayar.GHz.ToString(cultureInfo));
            Console.WriteLine("Hafıza: " + bilgisayar.Hafiza + " Gb");
            Console.WriteLine("Ekran: " + bilgisayar.EkranBoyutu.ToString(cultureInfo) + " İnç");
            Console.WriteLine("Su Soğutuma: " + (bilgisayar.SuSogutmaliMi ? "Var" : "Yok"));
            Console.WriteLine("Üretim Tarihi: " + bilgisayar.UretimTarihi.ToString(dateFormat));


        }
    }
}
