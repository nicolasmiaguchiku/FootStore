using FootStore.Application.Requests;
using FootStore.Application.Responses;
using FootStore.Domain.Models;
using LiteBus.Commands.Abstractions;

namespace FootStore.Application.Input.Commands;

public record AddOrderCommand(AddOrderRequest Request) : ICommand<Result<OrderResponse>>;