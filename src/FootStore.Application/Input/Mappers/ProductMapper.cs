using FootStore.Application.Input.Requests;
using FootStore.Domain.Entities;
using FootStore.Domain.ValueObjects;

namespace FootStore.Application.Input.Mappers
{
    public static class ProductMapper
    {
        public static ProductEntity ToDomain(this AddProductRequest request)
        {
            return new ProductEntity.Builder()
                .SetName(request.Name)
                .SetDescription(request.Description)
                .SetDetails(request.Details)
                .SetPrice(request.Price)
                .Build();
        }
    }
}