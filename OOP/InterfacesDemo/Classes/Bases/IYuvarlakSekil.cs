namespace InterfacesDemo.Classes.Bases
{
    interface IYuvarlakSekil
    {
        double Yaricap {  get; set; }
        bool PiUcMu { get; set; }

        double CevreHesapla();
        double AlanHesapla();
    }
}
