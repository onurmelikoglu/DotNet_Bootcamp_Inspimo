namespace ConstructorChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sub parametreliSub = new Sub(1.2, 'a', 3, true, "B");
            parametreliSub.SubMethod();
            parametreliSub.BaseMethod();

            Sub parametresizSub = new Sub();

        }
    }

    class Base
    {
        private int base1;

        protected bool base2;
        public string Base3 { get; set; }

        public Base(int base1, bool base2, string base3)
        {
            this.base1 = base1;
            this.base2 = base2;
            Base3 = base3;
            Console.WriteLine("Base constructor çalıştırıldı" + 
                "\nBase 1: "  + this.base1 +
                "\nBase 2: " + this.base2 +
                "\nBase 3: " + Base3 );
        }

        public Base()
        {
            Console.WriteLine("Base cosntructor çalıştırıldı");
        }

        public void BaseMethod()
        {
            Console.WriteLine("Base method çalıştırıldı" +
                "\nBase 1: " + base1 +
                "\nBase 2: " + base2 +
                "\nBase 3: " + Base3);
        }
    }

    class Sub : Base
    {
        private double sub1;
        public char Sub2 { get; set; }
        public Sub(double sub1, char sub2, int base1, bool base2, string base3) : base(base1, base2, base3)
        {
            this.sub1 = sub1;
            Sub2 = sub2;
            Console.WriteLine("Sub constroctor çalıştırıldı" +
                "\nSub 1: " + this.sub1 +
                "\nSub 2: " + Sub2
                );
        }

        public Sub(): base()
        {
            Console.WriteLine("Sub constroctor çalıştırıldı");
        }

        public void SubMethod()
        {
            Console.WriteLine("Sub method çalıştırıldı" +
                "\nSub 1: " + this.sub1 +
                "\nSub 2: " + Sub2
                );
            Console.WriteLine("Base2: " + base2 + "\nBase3: " + Base3);
        }
    }

}
