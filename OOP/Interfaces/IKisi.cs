namespace Interfaces
{
    public interface IKisi // abstract
    {
        // string tcKimlikNo; // field

        public string TcKimlikNo {  get; set; } // property

        string Adi { get; set; } // property
        string Soyadi { get; set; }

        string Getir(); // behavior
    }
}
