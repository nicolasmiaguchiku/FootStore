using FootStore.Application.Input.Requests;
using FootStore.Domain.Entities;

namespace FootStore.Application.Input.Mappers
{
    public static class ProductMapper
    {
        public static ProductEntity ToDomain(this AddProductRequest request)
        {
            return new ProductEntity.Builder()
                .SetName(request.Name)
                .SetDescription(request.Description)
                .SetPrice(request.Price)
                .SetSize(request.Size)
                .SetStock(request.Stock)
                .Build();
        }
    }
}