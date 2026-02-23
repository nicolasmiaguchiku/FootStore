using FootStore.Domain.Entities;
using FootStore.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;

namespace FootStore.Infrastructure.Repositories
{
    public class CustomerRepository(IMongoDatabase mongoDb, ILogger<CustomerRepository> logger) :
        BaseRepository<CustomerEntity>(mongoDb, "Customers", logger), ICustomerRepository;
}