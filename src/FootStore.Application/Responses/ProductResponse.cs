using FootStore.Domain.ValueObjects;

namespace FootStore.Application.Responses
{
    public record ProductResponse
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = default!;
        public string Description { get; init; } = default!;
        public decimal Price { get; init; }
        public IEnumerable<DetailsDto> Details { get; init; } = [];
    }
}