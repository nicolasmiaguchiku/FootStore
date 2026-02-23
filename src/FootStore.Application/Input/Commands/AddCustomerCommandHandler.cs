using FootStore.Application.Mappers;
using FootStore.Domain.Interfaces.Repositories;
using FootStore.Domain.Models;
using LiteBus.Commands.Abstractions;

namespace FootStore.Application.Input.Commands
{
    public sealed class AddCustomerCommandHandler(ICustomerRepository customerRepository) : ICommandHandler<AddCustomerCommand, Result>
    {
        public async Task<Result> HandleAsync(AddCustomerCommand message, CancellationToken cancellationToken = default)
        {
            await customerRepository.AddAsync(message.Request.ToEntity(), cancellationToken);

            return Result.Success();
        }
    }
}