using FootStore.Domain.Interfaces.Repositories;
using FootStore.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FootStore.CroosCutting.Extensions
{
    public static class RepositoriesExtenstions
    {
        public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            return services;
        }
    }
}