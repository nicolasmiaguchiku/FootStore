using FootStore.Domain.Entities;
using FootStore.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;

namespace FootStore.Infrastructure.Repositories
{
    public class ProductRepository(IMongoDatabase mongoDb, ILogger<ProductRepository> logger) :
        BaseRepository<ProductEntity>(mongoDb, "Products", logger), IProductRepository;
}
