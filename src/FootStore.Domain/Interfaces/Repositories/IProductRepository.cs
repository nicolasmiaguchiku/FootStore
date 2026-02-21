using FootStore.Domain.Entities;
using FootStore.Domain.Filters;
using FootStore.Domain.Models;

namespace FootStore.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IBaseRepository<ProductEntity>
    {
        Task<PagedResult<ProductEntity>> GetProductsAsync(ProductFiltersBuilder filters, CancellationToken cancellationToken);
    }
}