using FootStore.Application.Input.Commands;
using LiteBus.Commands.Extensions.MicrosoftDependencyInjection;
using LiteBus.Messaging.Extensions.MicrosoftDependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace FootStore.CroosCutting.Extensions
{
    public static class LiteBusExtentions
    {
        public static IServiceCollection ConfigureLiteBus(this IServiceCollection services)
        {
            services.AddLiteBus(litebus =>
            {
                litebus.AddCommandModule(module =>
                {
                    module.RegisterFromAssembly(typeof(AddProductCommandHandler).Assembly);
                });
            });

            return services;
        }
    }
}