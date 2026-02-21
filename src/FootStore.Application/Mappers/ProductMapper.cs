using FootStore.Application.Requests;
using FootStore.Application.Responses;
using FootStore.Domain.Entities;
using FootStore.Domain.Models;

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
                Name = entity.Name ?? "",
                Price = entity.Price,
                Description = entity.Description ?? "",
                Details = entity.Details
            };
        }

        public static PagedResult<ProductResponse> ToResponse(
          this PagedResult<ProductEntity> pagedResult,
          PageFilterRequest pageFilterRequest)
        {
            return new PagedResult<ProductResponse>
            {
                PageNumber = pageFilterRequest.Page,
                PageSize = pageFilterRequest.PageSize,
                TotalPages = pagedResult.TotalPages,
                TotalResults = pagedResult.TotalResults,
                Results = pagedResult.Results.Select(result => result.ToResponse())
            };
        }

        public static PagedResult<ProductResponse> ToResponse(this IEnumerable<ProductResponse> products, PageFilterRequest pageFilter)
        {
            return new PagedResult<ProductResponse>
            {
                PageNumber = pageFilter.Page,
                PageSize = pageFilter.PageSize,
                Results = products.Select(x => x),
                TotalPages = pageFilter.Page,
                TotalResults = products.Count()
            };
        }
    }
}