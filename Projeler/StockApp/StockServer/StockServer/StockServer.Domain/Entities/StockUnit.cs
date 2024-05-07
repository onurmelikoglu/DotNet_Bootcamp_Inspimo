using System.ComponentModel.DataAnnotations.Schema;
using StockServer.Domain.Abstractions;
using StockServer.Domain.Enums;
using StockServer.Domain.ValueObjects;

namespace StockServer.Domain.Entities;

public sealed class StockUnit : Entity
{
    public string Code { get; set; } = string.Empty;
    [ForeignKey("StockType")]
    public int StockTypeId { get; set; }
    public StockType? StockType { get; set; }
    public QuantityUnitEnum? QuantityUnit { get; set; } = QuantityUnitEnum.Adet;
    public string Description { get; set; } = string.Empty;
    public Money Buying { get; set; } = Money.Zero();
    public Money Selling { get; set; } = Money.Zero();
    public int PaperWeight { get; set; }
}