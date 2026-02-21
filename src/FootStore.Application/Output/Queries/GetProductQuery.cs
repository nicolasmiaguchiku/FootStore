using FootStore.Application.Output.Responses;
using FootStore.Domain.Models;
using LiteBus.Queries.Abstractions;

namespace FootStore.Application.Output.Queries;

public record GetProductQuery(Guid Id) : IQuery<Result<ProductResponse>>;