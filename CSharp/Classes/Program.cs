namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan1;
            insan1 = new Insan();
            insan1.setAdi("Onur");
            insan1.setSoyadi("Melikoglu");
            insan1.setYasi(30);
            Console.WriteLine(insan1.getAdi() + " " + insan1.getSoyadi() + " " + insan1.getYasi() );

            Insan insan2 = new Insan();
        }
    }

    class Insan
    {
        string _adi; // fields, alan
        string _soyadi;
        int _yasi;

        public void setAdi(string adi) // behavior, setter
        {
            _adi = adi;
        }

        public string getAdi() // behavior, getter
        {
            return _adi;
        }

        public void setSoyadi(string soyadi)
        {
            _soyadi = soyadi;
        }

        public string getSoyadi()
        {
            return _soyadi;
        }

        public void setYasi(int yasi)
        {
            _yasi = yasi;
        }

        public int getYasi()
        {
            return _yasi;
        }

    }

}
