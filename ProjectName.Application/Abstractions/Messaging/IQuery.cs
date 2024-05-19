using ProjectName.Domain.Abstractions;
using MediatR;

namespace ProjectName.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}