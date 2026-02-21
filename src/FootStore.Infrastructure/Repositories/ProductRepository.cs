using FootStore.Domain.Entities;
using FootStore.Domain.Filters;
using FootStore.Domain.Interfaces.Repositories;
using FootStore.Domain.Models;
using FootStore.Infrastructure.Stage;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace FootStore.Infrastructure.Repositories
{
    public class ProductRepository(IMongoDatabase mongoDb, ILogger<ProductRepository> logger) :
        BaseRepository<ProductEntity>(mongoDb, "Products", logger), IProductRepository
    {
        private readonly IMongoCollection<ProductEntity> _collection = mongoDb.GetCollection<ProductEntity>("Products");

        public async Task<PagedResult<ProductEntity>> GetProductsAsync(ProductFiltersBuilder filters, CancellationToken cancellationToken)
        {
            var pipeline = PipelineDefinitionBuilder
                .For<ProductEntity>()
                .As<ProductEntity, ProductEntity, BsonDocument>()
                .FilterProducts(filters);

            var options = new AggregateOptions { AllowDiskUse = true };
            var aggregation = await _collection.AggregateAsync(pipeline, options, cancellationToken);

            var bsonDocuments = await aggregation.ToListAsync(cancellationToken);

            var products = bsonDocuments
                .Select(bsonDocument => BsonSerializer.Deserialize<ProductEntity>(bsonDocument))
                .ToList();

            return new PagedResult<ProductEntity>
            {
                PageSize = filters.PageSize,
                Results = products,
                TotalResults = products.Count
            };
        }
    }
}
