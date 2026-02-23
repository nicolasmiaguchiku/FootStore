namespace FootStore.Domain.ValueObjects
{
    public class AddressDto
    {
        public string Street { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Number { get; set; } = default!;
        public string Code { get; set; } = default!;
        public string Neighborhood { get; set; } = default!;
        public string Complement { get; set; } = default!;
        public string Uf { get; set; } = default!;
    }
}