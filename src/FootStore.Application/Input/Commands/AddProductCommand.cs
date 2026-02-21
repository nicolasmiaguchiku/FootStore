using FootStore.Application.Requests;
using FootStore.Domain.Models;
using LiteBus.Commands.Abstractions;

namespace FootStore.Application.Input.Commands;

public record AddProductCommand(AddProductRequest Request) : ICommand<Result>;