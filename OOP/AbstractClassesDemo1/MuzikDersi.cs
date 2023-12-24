using AbstractClassesDemo1.Bases;

namespace AbstractClassesDemo1
{
    public class MuzikDersi : DersBase
    {
        public override string KodGetir()
        {
            return "MZK-" + Id;
        }

        public override double MaksimumNotGetir()
        {
            return 10;
        }

    }
}
