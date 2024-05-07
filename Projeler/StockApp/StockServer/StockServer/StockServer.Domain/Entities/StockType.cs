using StockServer.Domain.Abstractions;

namespace StockServer.Domain.Entities;

public sealed class StockType : Entity
{
    public string Name { get; set; } = string.Empty;
}