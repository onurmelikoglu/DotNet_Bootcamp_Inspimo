using GenericRepository;
using MediatR;
using StockServer.Domain.Entities;
using StockServer.Domain.Repositories;

namespace StockServer.Application.Features.Stocks.DeleteStockById;

internal sealed class DeleteStockByIdCommandHandler(
    IStockRepository stockRepository,
    IUnitOfWork unitOfWork
) : IRequestHandler<DeleteStockByIdCommand>
{
    public async Task Handle(DeleteStockByIdCommand request, CancellationToken cancellationToken)
    {
        Stock? stock =
            await stockRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id, cancellationToken);

        if (stock is null)
        {
            throw new ArgumentException("Stock Bulunmadı");
        }

        stockRepository.Delete(stock);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}