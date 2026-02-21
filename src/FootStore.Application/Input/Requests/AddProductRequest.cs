namespace FootStore.Application.Input.Requests
{
    public record AddProductRequest
    {
        public string Name { get; init; } = default!;
        public string Description { get; init; } = default!;
        public decimal Price { get; init; }
        public string Size { get; init; } = default!;
        public int Stock { get; init; }
    }
}