using FootStore.Domain.ValueObjects;

namespace FootStore.Application.Requests;

public record AddProductRequest(string Name, string Description, decimal Price, IEnumerable<DetailsDto> Details);