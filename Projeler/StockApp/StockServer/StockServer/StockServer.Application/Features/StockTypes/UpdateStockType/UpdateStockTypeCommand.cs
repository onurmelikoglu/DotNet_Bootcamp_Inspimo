using GenericRepository;
using MediatR;
using StockServer.Domain.Entities;
using StockServer.Domain.Repositories;

namespace StockServer.Application.Features.StockTypes.UpdateStockType;

public sealed record UpdateStockTypeCommand(int Id, string Name, bool IsActive) : IRequest;

internal sealed class UpdateStockTypeCommandHandler(IStockTypeRepository stockTypeRepository, IUnitOfWork unitOfWork) : IRequestHandler<UpdateStockTypeCommand>
{
    public async Task Handle(UpdateStockTypeCommand request, CancellationToken cancellationToken)
    {
        StockType stockType =
            await stockTypeRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id, cancellationToken);

        if (stockType is null)
        {
            throw new ArgumentException("Stock türü bulunamadı");
        }

        if (stockType.Name != request.Name)
        {
            bool isNameExists = await stockTypeRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);
            if (isNameExists)
            {
                throw new ArgumentException("Stock türü adı daha önce kullanılmıs");
            }
        }

        stockType.Name = request.Name;
        stockType.IsActive = request.IsActive;
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}