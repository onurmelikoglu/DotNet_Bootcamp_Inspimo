using Ardalis.SmartEnum;

namespace StockServer.Domain.Enums;

public sealed class StockClassEnum : SmartEnum<StockClassEnum>
{
    public static readonly StockClassEnum Hammadde = new("Hammadde", 1);
    public static readonly StockClassEnum YariMamul = new("Yari Mamul", 2);
    public static readonly StockClassEnum Mamul = new("Mamul", 3);
    public StockClassEnum(string name, int value) : base(name, value)
    {
    }
}