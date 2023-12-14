namespace InterfaceSegregation
{
    internal class Program
    {
        // SOLID
        // S: single responsibility
        // I: interface segregation
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    interface ICalisan
    {
        void Calis();
        void MaasAl();
        void YemekYe();
    }

    //class Calisan : ICalisan
    //{
    //    public void Calis()
    //    {
    //        Console.WriteLine("Çalışan Çalışıyor");
    //    }

    //    public void MaasAl()
    //    {
    //        Console.WriteLine("Çalışan Maaş ALıyor");
    //    }

    //    public void YemekYe()
    //    {
    //        Console.WriteLine("Çalışan Yemek Yiyor");
    //    }
    //}

    //class Yonetici : ICalisan
    //{
    //    public void Calis()
    //    {
    //        Console.WriteLine("Yonetici Çalışıyor");
    //    }

    //    public void MaasAl()
    //    {
    //        Console.WriteLine("Yonetici Maaş ALıyor");
    //    }

    //    public void YemekYe()
    //    {
    //        Console.WriteLine("Yonetici Yemek Yiyor");
    //    }
    //}

    //class Robot : ICalisan
    //{
    //    public void Calis()
    //    {
    //        Console.WriteLine("Robot Çalışıyor");
    //    }

    //    public void MaasAl()
    //    {
            
    //    }

    //    public void YemekYe()
    //    {
            
    //    }
    //}

    interface ICalis
    {
        void Calis();
    }

    interface IInsan
    {
        void MaasAl();
        void YemekYe();
    }

    class Calisan : ICalisan, IInsan
    {
        public void Calis()
        {
            Console.WriteLine("Çalışan Çalışıyor");
        }

        public void MaasAl()
        {
            Console.WriteLine("Çalışan Maaş ALıyor");
        }

        public void YemekYe()
        {
            Console.WriteLine("Çalışan Yemek Yiyor");
        }
    }

    class Yonetici : ICalis, IInsan
    {
        public void Calis()
        {
            Console.WriteLine("Yonetici Çalışıyor");
        }

        public void MaasAl()
        {
            Console.WriteLine("Yonetici Maaş ALıyor");
        }

        public void YemekYe()
        {
            Console.WriteLine("Yonetici Yemek Yiyor");
        }
    }

    class Robot : ICalis
    {
        public void Calis()
        {
            Console.WriteLine("Robot Çalışıyor");
        }
    }
}
