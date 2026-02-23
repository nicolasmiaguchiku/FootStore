using FootStore.Domain.ValueObjects;

namespace FootStore.Domain.Entities
{
    public class CustomerEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string Cpf { get; set; } = default!;
        public AddressDto Address { get; set; } = default!;

        public CustomerEntity SetId(Guid id)
        {
            Id = id;
            return this;
        }

        public CustomerEntity SetName(string name)
        {
            Name = name;
            return this;
        }

        public CustomerEntity SetEmail(string email)
        {
            Email = email;
            return this;
        }

        public CustomerEntity SetCpf(string cpf)
        {
            Cpf = cpf;
            return this;
        }

        public CustomerEntity SetAddressDto(AddressDto address)
        {
            Address = address;
            return this;
        }

        public CustomerEntity SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
            return this;
        }

        public Builder ToBuilder()
        {
            return new Builder
            {
                Id = Id,
                Name = Name,
                Email = Email,
                Cpf = Cpf,
                PhoneNumber = PhoneNumber,
                Address = Address
            };
        }

        public class Builder
        {
            public Guid Id { get; set; }
            public string Name { get; set; } = default!;
            public string Email { get; set; } = default!;
            public string Cpf { get; set; } = default!;
            public string PhoneNumber { get; set; } = default!;
            public AddressDto Address { get; set; } = default!;

            public static Builder Create() => new();

            public Builder SetId(Guid id) { Id = id; return this; }
            public Builder SetName(string name) { Name = name; return this; }
            public Builder SetEmail(string email) { Email = email; return this; }
            public Builder SetCpf(string cpf) { Cpf = cpf; return this; }
            public Builder SetPhoneNumber(string phoneNumber) { PhoneNumber = phoneNumber; return this; }
            public Builder SetAddressDto(AddressDto address) { Address = address; return this; }

            public CustomerEntity Build()
            {
                return new CustomerEntity
                {
                    Id = Id,
                    Name = Name,
                    Email = Email,
                    Cpf = Cpf,
                    PhoneNumber = PhoneNumber,
                    Address = Address
                };
            }
        }
    }
}
