using FootStore.Domain.ValueObjects;

namespace FootStore.Application.Requests;

public record AddCustomerRequest(string Name, string Email, string Cpf, string PhoneNumber, AddressDto Address);