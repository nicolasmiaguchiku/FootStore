using FootStore.Application.Requests;
using FootStore.Application.Responses;
using FootStore.Domain.Models;
using LiteBus.Queries.Abstractions;

namespace FootStore.Application.Output.Queries;

public record GetProductQuery(GetProducRequest Request) : IQuery<Result<PagedResult<ProductResponse>>>;