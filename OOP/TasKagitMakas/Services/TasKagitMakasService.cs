using TasKagitMakas.Models.Bases;
using TasKagitMakas.Services.Bases;

namespace TasKagitMakas.Services
{
    public class TasKagitMakasService : ITasKagitMakasService
    {
        private readonly OyuncuBase oyuncu;
        Random random;
        Dictionary<char, string> hareketler = new Dictionary<char, string>()
        {
            {'k', "Kağıt" },
            {'m', "Makas" },
            {'t', "Taş" },
        };

        public TasKagitMakasService(OyuncuBase oyuncu)
        {
            this.oyuncu = oyuncu;
            random = new Random();
        }

        public void YeniOyunaBasla()
        {
            oyuncu.KazanmaSayisi = 0;
        }
        public string Oyna(char oyuncuHareketi, string sonuc = null)
        {
            int rastgeleSayi = random.Next(1, 4);
            char bilgisayarHareketi = rastgeleSayi == 1 ? 'k' : rastgeleSayi == 2 ? 'm' : 't';
            if(bilgisayarHareketi == oyuncuHareketi)
            {
                sonuc = Oyna(oyuncuHareketi, sonuc);
            }
            else
            {
                sonuc = "\nBilgisayar: " + hareketler[bilgisayarHareketi] + "\nOyuncu: " + hareketler[oyuncuHareketi];
                if(bilgisayarHareketi == 'k')
                {
                    if(oyuncuHareketi == 'm')
                    {
                        sonuc += "\n\"" + oyuncu.Rumuzu + "\" kazandı. \nKazanma Sayısı: " + ++oyuncu.KazanmaSayisi;
                    }
                    else
                    {
                        sonuc += "\nBilgisayar kazandı.";
                    }
                }else if (bilgisayarHareketi == 'm')
                {
                    if (oyuncuHareketi == 't')
                    {
                        sonuc += "\n\"" + oyuncu.Rumuzu + "\" kazandı. \nKazanma Sayısı: " + ++oyuncu.KazanmaSayisi;
                    }
                    else
                    {
                        sonuc += "\nBilgisayar kazandı.";
                    }
                }
                else
                {
                    if (oyuncuHareketi == 'k')
                    {
                        sonuc += "\n\"" + oyuncu.Rumuzu + "\" kazandı. \nKazanma Sayısı: " + ++oyuncu.KazanmaSayisi;
                    }
                    else
                    {
                        sonuc += "\nBilgisayar kazandı.";
                    }
                }
            }
            return sonuc;
        }

       
    }
}
