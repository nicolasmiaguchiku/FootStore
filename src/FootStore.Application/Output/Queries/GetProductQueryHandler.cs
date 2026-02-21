using FootStore.Application.Mappers;
using FootStore.Application.Output.Responses;
using FootStore.Domain.Interfaces.Repositories;
using FootStore.Domain.Models;
using LiteBus.Queries.Abstractions;

namespace FootStore.Application.Output.Queries
{
    public sealed class GetProductQueryHandler(IProductRepository productRepository) : IQueryHandler<GetProductQuery, Result<ProductResponse>>
    {
        public async Task<Result<ProductResponse>> HandleAsync(GetProductQuery message, CancellationToken cancellationToken = default)
        {
            var product = await productRepository.GetOneAsync(x => x.Id == message.Id, cancellationToken);

            return Result<ProductResponse>.Success(product!.ToResponse());
        }
    }
}