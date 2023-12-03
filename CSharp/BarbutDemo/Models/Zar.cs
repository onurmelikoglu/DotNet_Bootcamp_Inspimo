namespace BarbutDemo.Models
{
    class Zar
    {
        int _sayi = 0;
        Random rastgele = new Random();

        public int At()
        {
            _sayi = rastgele.Next(1, 7);
            return _sayi;
        }
    }
}
