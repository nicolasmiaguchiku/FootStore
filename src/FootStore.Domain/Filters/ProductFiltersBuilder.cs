namespace FootStore.Domain.Filters
{
    public class ProductFiltersBuilder : PaginationFilter
    {
        public IEnumerable<Guid>? Ids { get; private set; }
        public IEnumerable<string>? Names { get; private set; }

        private ProductFiltersBuilder() { }

        public sealed class Builder
        {
            private readonly ProductFiltersBuilder _filters = new();

            public Builder WithNames(IEnumerable<string>? names)
            {
                _filters.Names = names;
                return this;
            }

            public Builder WithFoodIds(IEnumerable<Guid>? Ids)
            {
                _filters.Ids = Ids;
                return this;
            }

            public ProductFiltersBuilder Build() => _filters;
        }
    }
}