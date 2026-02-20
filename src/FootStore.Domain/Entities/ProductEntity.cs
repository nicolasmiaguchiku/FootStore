namespace FootStore.Domain.Entities
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; } = default!;
        public int Size { get; set; }
        public string Stock { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;

        public ProductEntity SetId(Guid id)
        {
            Id = id;
            return this;
        }

        public ProductEntity SetName(string name)
        {
            Name = name;
            return this;
        }

        public ProductEntity SetDescription(string description)
        {
            Description = description;
            return this;
        }

        public ProductEntity SetPrice(decimal price)
        {
            Price = price;
            return this;
        }

        public ProductEntity SetSize(int size)
        {
            Size = size;
            return this;
        }

        public ProductEntity SetStock(string stock)
        {
            Stock = stock;
            return this;
        }

        public ProductEntity SetImageUrl(string imageUrl)
        {
            ImageUrl = imageUrl;
            return this;
        }

        public Builder ToBuilder()
        {
            return new Builder
            {
                Id = Id,
                Name = Name,
                Description = Description,
                Price = Price,
                Size = Size,
                Stock = Stock,
                ImageUrl = ImageUrl
            };
        }

        public class Builder
        {
            public Guid Id { get; set; }
            public string Name { get; set; } = default!;
            public string Description { get; set; } = default!;
            public decimal Price { get; set; }
            public int Size { get; set; }
            public string Stock { get; set; } = default!;
            public string ImageUrl { get; set; } = default!;

            public static Builder Create() => new();

            public Builder SetId(Guid id) { Id = id; return this; }
            public Builder SetName(string name) { Name = name; return this; }
            public Builder SetDescription(string description) { Description = description; return this; }
            public Builder SetPrice(decimal price) { Price = price; return this; }
            public Builder SetSize(int size) { Size = size; return this; }
            public Builder SetStock(string stock) { Stock = stock; return this; }
            public Builder SetImageUrl(string imageUrl) { ImageUrl = imageUrl; return this; }

            public ProductEntity Build()
            {
                return new ProductEntity
                {
                    Id = Id,
                    Name = Name,
                    Description = Description,
                    Price = Price,
                    Size = Size,
                    Stock = Stock,
                    ImageUrl = ImageUrl
                };
            }
        }
    }
}