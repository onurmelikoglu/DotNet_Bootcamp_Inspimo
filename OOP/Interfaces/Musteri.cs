namespace Interfaces
{
    public class Musteri : IKisi
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KrediKartiNo { get; set; }
        public string KrediKartiNoGizle() => "**** **** **** " + KrediKartiNo.Substring(KrediKartiNo.Length - 4, 4);

        public string Getir()
        {
            return $"T.C Kimlik No: {TcKimlikNo}\nÖğrenci: {Adi} {Soyadi}";
        }
    }
}
