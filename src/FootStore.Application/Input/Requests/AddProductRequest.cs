using FootStore.Domain.ValueObjects;

namespace FootStore.Application.Input.Requests
{
    public record AddProductRequest
    {
        public string Name { get; init; } = default!;
        public string Description { get; init; } = default!;
        public IEnumerable<DetailsDto> Details { get; set; } = [];
        public decimal Price { get; init; }
    }
}