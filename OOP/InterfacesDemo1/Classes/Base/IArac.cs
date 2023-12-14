namespace InterfacesDemo1.Classes.Base
{
    interface IArac
    {
        int TekerlekSayisi { get; set; }
        YakitTipi YakitTipi { get; set; }
        string Marka { get; set; }
        string Model { get; set; }
        int BeygirGucu { get; set; }
        int MotorHacmi { get; set; }
        // bool DiresiyonSoldaMi { get; set; }

        string AracBilgileriniGetir(string satirSonu = " ");
    }
}
