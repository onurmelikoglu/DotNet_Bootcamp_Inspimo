namespace Interfaces
{
    public class Ogrenci : IKisi
    {
        // behavior
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Universite { get; set; }

        public string Getir()
        {
            return $"T.C Kimlik No: {TcKimlikNo}\nÖğrenci: {Adi} {Soyadi}";
        }
    }
}
