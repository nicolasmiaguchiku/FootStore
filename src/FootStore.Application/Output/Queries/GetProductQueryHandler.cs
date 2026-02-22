using FootStore.Application.Mappers;
using FootStore.Application.Responses;
using FootStore.Domain.Filters;
using FootStore.Domain.Interfaces.Repositories;
using FootStore.Domain.Models;
using LiteBus.Messaging.Abstractions;
using LiteBus.Queries.Abstractions;

namespace FootStore.Application.Output.Queries
{
    public sealed class GetProductQueryHandler(IProductRepository productRepository) : IQueryHandler<GetProductQuery, Result<PagedResult<ProductResponse>>>
    {
        public async Task<Result<PagedResult<ProductResponse>>> HandleAsync(GetProductQuery message, CancellationToken cancellationToken)
        {
            var productsFilterBuilder = new ProductFiltersBuilder.Builder()
                .WithFoodIds(message.Request.Ids)
                .WithNames(message.Request.Names)
                .Build();

            var produts = await productRepository.GetProductsAsync(productsFilterBuilder, cancellationToken);

            var result = produts.ToResponse(message.Request.PageFilter);

            return Result<PagedResult<ProductResponse>>.Success(result);
        }
    }
}