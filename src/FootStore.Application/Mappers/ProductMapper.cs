using FootStore.Application.Input.Requests;
using FootStore.Application.Output.Responses;
using FootStore.Domain.Entities;
using FootStore.Domain.ValueObjects;

namespace FootStore.Application.Mappers
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

        public static ProductResponse ToResponse(this ProductEntity entity)
        {
            return new ProductResponse
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Details = entity.Details,
                Price = entity.Price
            };
        }
    }
}