using AbstractClasses.Bases;

namespace AbstractClasses
{
    public class Product : RecordBase
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int StockAmount { get; set; }

    }
}
