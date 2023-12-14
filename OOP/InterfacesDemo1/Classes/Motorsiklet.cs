﻿using InterfacesDemo1.Classes.Base;

namespace InterfacesDemo1.Classes
{
    internal class Motorsiklet : IArac
    {
        public int TekerlekSayisi { get; set; }
        public YakitTipi YakitTipi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int BeygirGucu { get; set; }
        public int MotorHacmi { get; set; }

        public string AracBilgileriniGetir(string satirSonu = " ")
        {
            return $"Marka: {Marka}{satirSonu}" +
                $"Model: {Model}{satirSonu}" +
                $"Motor Hacmi: {MotorHacmi} cc{satirSonu}" +
                $"Beygir Gucu: {BeygirGucu} hp{satirSonu}" +
                $"Tekerlek sayısı: {TekerlekSayisi}{satirSonu}" +
                $"Yakıt Tipi: : {YakitTipi}";
        }
    }
}
