namespace InterfacesDemo.Classes.Bases
{
    interface IKoseliSekil
    {
        double Genislik {  get; set; } // Özellik
        double Yukseklik {  get; set; }

        double CevreHesapla(); // Davranış
        double AlanHesapla();
    }
}
