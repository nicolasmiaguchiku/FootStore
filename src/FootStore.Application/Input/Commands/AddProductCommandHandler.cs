using FootStore.Application.Mappers;
using FootStore.Domain.Interfaces.Repositories;
using FootStore.Domain.Models;
using LiteBus.Commands.Abstractions;

namespace FootStore.Application.Input.Commands
{
    public sealed class AddProductCommandHandler(IProductRepository productRepository) : ICommandHandler<AddProductCommand, Result>
    {
        public async Task<Result> HandleAsync(AddProductCommand message, CancellationToken cancellationToken = default)
        {
            await productRepository.AddAsync(message.Request.ToDomain(), cancellationToken);

            return Result.Success();
        }
    }
}