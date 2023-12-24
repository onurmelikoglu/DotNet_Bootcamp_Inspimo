using ArrayOfObjects_TimeSpan_Casting.Enums;
using ArrayOfObjects_TimeSpan_Casting.Models;
using ArrayOfObjects_TimeSpan_Casting.Models.Bases;
using System.Globalization;

namespace ArrayOfObjects_TimeSpan_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medya[] medya = new Medya[]
            {
                new Video()
                {
                    Adi = "Fade to Black",
                    CikisTarihi = DateTime.Parse("18.04,2008", new CultureInfo("tr-TR")),
                    Suresi = TimeSpan.Parse("00:04:02"),
                    GoruntuFormati = GoruntuFormati.SD
                },
                new Sarki()
                {
                    Adi = "I Want It All",
                    Album = "The Miracle",
                    CikisTarihi = DateTime.Parse("01.02.1989", new CultureInfo("tr-TR")),
                    Sanatci = "Queen",
                    Suresi = TimeSpan.FromSeconds(297),
                    TLfiyati = 3.99m
                },
                new Film()
                {
                    Adi = "Avatar",
                    CikisTarihi = new DateTime(2009, 12, 18),
                    Suresi = TimeSpan.Parse("02:42"),
                    TLfiyati = 9.99m,
                    GoruntuFormati = GoruntuFormati.UltraHD,
                    Yonetmen = "James Cameron",
                    Oyuncular = ["Zoe Saldana", "Sam Worthigton"],
                    ImdbPuani = 7.9f


                }

            };

            foreach(Medya m in medya)
            {
                Console.WriteLine("medya adı: " + m.Adi);
            }

            Film film;
            Sarki sarki;
            Video video;
            foreach(Medya m in medya)
            {
                Console.WriteLine("medya adı: " + m.Adi);
                if (m is Film)
                {
                    film = m as Film;
                    Console.WriteLine($"Yonetmeni: {film.Yonetmen}");
                    Console.WriteLine($"Imdb Puanı: {film.ImdbPuani}");
                    Console.WriteLine($"Görüntü Formatı: {film.GoruntuFormati}");
                    Console.WriteLine($"Oyuncular: {string.Join("\n",film.Oyuncular)}");
                }
                else if(m is Sarki)
                {
                    sarki = (Sarki)m;
                    Console.WriteLine($"Sanatçı: {sarki.Sanatci}");
                    Console.WriteLine($"Albüm: {sarki.Album}");
                    Console.WriteLine($"Format: {(sarki.Mp3mu ? "Mp3":"Diğer")}");
                }
                else
                {
                    video = m as Video;
                    Console.WriteLine($"Video Formatı: {video.GoruntuFormati}");
                }
            }
        }
    }
}
