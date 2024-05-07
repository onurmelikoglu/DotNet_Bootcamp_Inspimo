using GenericRepository;
using MediatR;
using StockServer.Domain.Entities;
using StockServer.Domain.Repositories;

namespace StockServer.Application.Features.StockTypes.DeleteStockTypeById;

internal sealed class DeleteStockTypeByIdCommandHandler(IStockTypeRepository stockTypeRepository, IUnitOfWork unitOfWork) : IRequestHandler<DeleteStockTypeByIdCommand>
{
    public async Task Handle(DeleteStockTypeByIdCommand request, CancellationToken cancellationToken)
    {
        StockType stockType =
            await stockTypeRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id, cancellationToken);
        if (stockType is null)
        {
            throw new ArgumentException("Stock Türü bulunamadı");
        }
        
        stockTypeRepository.Delete(stockType);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}