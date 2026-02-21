using FootStore.Domain.Entities;
using FootStore.Domain.Filters;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FootStore.Infrastructure.Stage
{
    public static class ProductFiltersBuilderStage
    {
        public static PipelineDefinition<ProductEntity, BsonDocument> FilterProducts(this PipelineDefinition<ProductEntity, BsonDocument> pipelineDefinition,
            ProductFiltersBuilder queryFilter)
        {
            var matchFilter = BuildMatchFilter(queryFilter);
            if (matchFilter != FilterDefinition<BsonDocument>.Empty)
            {
                pipelineDefinition = pipelineDefinition.Match(matchFilter);
            }

            return pipelineDefinition;
        }

        private static FilterDefinition<BsonDocument> BuildMatchFilter(ProductFiltersBuilder queryFilter)
        {
            var filters = new List<FilterDefinition<BsonDocument>>
        {
            MatchByCustomerIds(queryFilter),
            MatchByNames(queryFilter),
        };

            filters.RemoveAll(filter => filter == FilterDefinition<BsonDocument>.Empty);

            return filters.Count switch
            {
                0 => FilterDefinition<BsonDocument>.Empty,
                1 => filters[0],

                _ => Builders<BsonDocument>.Filter.And(filters)
            };
        }

        private static FilterDefinition<BsonDocument> MatchByCustomerIds(ProductFiltersBuilder queryFilter)
        {
            if (queryFilter?.Ids == null || !queryFilter.Ids.Any())
            {
                return FilterDefinition<BsonDocument>.Empty;
            }

            var bsonGuids = queryFilter!.Ids!
                .Select(id => new BsonBinaryData(id, GuidRepresentation.Standard));

            var filter = new BsonDocument("_id", new BsonDocument("$in", new BsonArray(bsonGuids)));

            return filter;
        }

        private static FilterDefinition<BsonDocument> MatchByNames(ProductFiltersBuilder queryFilter)
        {
            if (queryFilter?.Names == null || !queryFilter.Names.Any())
                return FilterDefinition<BsonDocument>.Empty;

            return new BsonDocument("Name", new BsonDocument("$in", new BsonArray(queryFilter.Names)));
        }
    }
}