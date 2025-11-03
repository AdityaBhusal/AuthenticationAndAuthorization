using AuthenticationAndAuthorization.Application.Features.Auth.UserDetails.Models;
using MediatR;

namespace AuthenticationAndAuthorization.Application.Features.Auth.UserDetails.Commands.RegisterEmail
{
    public record RegisterEmailCommand(RegisterEmailDto Dto) : IRequest<string>;
    
}
