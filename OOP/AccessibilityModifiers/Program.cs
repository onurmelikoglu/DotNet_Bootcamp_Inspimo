namespace AccessibilityModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base b1 = new Base();
            b1.DisplayBasePrivate2();

            Base b2 = new Base();
            b2.DisplayBasePrivate2();

            Sub s1 = new Sub();
            s1.DisplayBasePrivate2();
            
            Sub s2 = new Sub()
            {
                public1 = 1,
                Public2 = 2
            };

            s2.DisplaySubPublic();


        }
    }

    public class Base
    {
        #region Private
        private bool private1; // field
        byte private2; // field

        private short Private3 { get; set; } = 3; // property

        private void SetBasePrivate()
        {
            bool local1 = true;

            private1 = local1;
            private2 = 22;
            Private3 = 23;
        }

        void DisplayBasePrivate()
        {
            Console.WriteLine("private1: " + private1);
            Console.WriteLine("private2: " + private2);
            Console.WriteLine("private3: " + Private3);
        }

        public void DisplayBasePrivate2()
        {
            DisplayBasePrivate();
        }
        #endregion

        #region Protected
        protected int protecetd1;

        protected int Protected2 { get; set; }

        protected void SetBaseProtected()
        {
            private2 = 222;
            Protected2 = 222;
        }

        protected void DisplayBaseProtected()
        {
            DisplayBasePrivate2();
            Console.WriteLine("protected1: " + protecetd1);
            Console.WriteLine("protected2: " + Protected2);
        }

        protected void DisplayBaseProtected2()
        {
            DisplayBaseProtected();
        }

        #endregion

        #region Public
        public int public1;
        public int Public2 { get; set; }

        public void DisplayBasePublic()
        {
            Private3 = 33;
            DisplayBaseProtected2();
        }
        #endregion

    }

    public class Sub : Base
    {
        private void DisplaySubPrivate()
        {
            protecetd1 = 1111;
            Protected2 = 2222;

            DisplayBasePrivate2();
        }

        protected void DisplaySubProtected()
        {
            protecetd1 = 1111;
            Protected2 = 2222;

            DisplayBasePrivate2();
        }

        public void DisplaySubPublic()
        {
            Public2 = 22222;
            public1 = 121212;
        }
    }
}
