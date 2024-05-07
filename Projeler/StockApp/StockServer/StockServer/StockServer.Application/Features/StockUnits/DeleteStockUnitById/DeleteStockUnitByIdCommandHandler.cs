using GenericRepository;
using MediatR;
using StockServer.Domain.Entities;
using StockServer.Domain.Repositories;

namespace StockServer.Application.Features.StockUnits.DeleteStockUnitById;

internal sealed class DeleteStockUnitByIdCommandHandler(
    IStockUnitRepository stockUnitRepository,
    IUnitOfWork unitOfWork
) : IRequestHandler<DeleteStockUnitByIdCommand>
{
    public async Task Handle(DeleteStockUnitByIdCommand request, CancellationToken cancellationToken)
    {
        StockUnit stockUnit =
            await stockUnitRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id, cancellationToken);

        if (stockUnit is null)
        {
            throw new ArgumentException("Stok Birimi Bulunamadı");
        }
        
        stockUnitRepository.Delete(stockUnit);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}