using InterfacesDemo.Classes;
using InterfacesDemo.Classes.Bases;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen()
            {
                Genislik = 4,
                Yukseklik = 5,
            };
            Console.WriteLine("Dikdörtgen Alan: " + dikdortgen.AlanHesapla());
            Console.WriteLine("Dikdörtgen Alan: " + dikdortgen.CevreHesapla());

            Dikdortgen kare = new Dikdortgen()
            {
                Genislik = 5,
                Yukseklik = 5,
            };
            Console.WriteLine("Dikdörtgen Alan: " + kare.AlanHesapla());
            Console.WriteLine("Dikdörtgen Alan: " + kare.CevreHesapla());

            IKoseliSekil[] sekiller = new IKoseliSekil[3];
            sekiller[0] = new Dikucgen()
            {
                Genislik = 3,
                Yukseklik = 4
            };
            sekiller[1] = new Dikdortgen()
            {
                Genislik = 6,
                Yukseklik = 8
            };
            sekiller[2] = new Dikdortgen()
            {
                Genislik = 10,
                Yukseklik = 10
            };

            foreach(IKoseliSekil sekil in sekiller)
            {
                if(sekil is Dikucgen)
                {
                    Console.WriteLine("Dikucgen");
                }
                else if(sekil is Dikdortgen)
                {
                    if(sekil.Genislik != sekil.Yukseklik)
                    {
                        Console.WriteLine("Dikdortgen");
                    }
                    else
                    {
                        Console.WriteLine("Kare");
                    }

                }
                
                Console.WriteLine("Alan: " + sekil.AlanHesapla() + "\nÇevre: " + sekil.CevreHesapla() );
            }

            EskenarUcgen eskenarUcgen = new EskenarUcgen()
            {
                Genislik = 5,
            };
            Console.WriteLine("eskenarUcgen Alan: " + eskenarUcgen.AlanHesapla());
            Console.WriteLine("eskenarUcgen Çevre: " + eskenarUcgen.CevreHesapla());

            IYuvarlakSekil daire = new Daire(2, false);
            Console.WriteLine("Daire Alan: " + daire.AlanHesapla());
            Console.WriteLine("Daire Çevre: " + daire.CevreHesapla());


        }
    }
}
