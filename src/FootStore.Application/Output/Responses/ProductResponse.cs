using FootStore.Domain.ValueObjects;

namespace FootStore.Application.Output.Responses
{
    public class ProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        public IEnumerable<DetailsDto> Details { get; set; } = [];
    }
}