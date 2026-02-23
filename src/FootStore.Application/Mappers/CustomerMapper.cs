using FootStore.Application.Requests;
using FootStore.Domain.Entities;

namespace FootStore.Application.Mappers
{
    public static class CustomerMapper
    {
        public static CustomerEntity ToEntity(this AddCustomerRequest request)
        {
            return new CustomerEntity
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address
            };
        }
    }
}