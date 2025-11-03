using AuthenticationAndAuthorization.Application.Features.Auth.UserDetails.Models;
using AuthenticationAndAuthorization.Domain.Entities;
using AuthenticationAndAuthorization.Infrastructure.Persistence.DbContexts;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAndAuthorization.Application.Features.Auth.UserDetails.Commands.RegisterEmail
{
    public class RegisterEmailCommandHandler : IRequestHandler<RegisterEmailCommand, string>
    {
        private readonly CredsDbContext _credsContext;
        public RegisterEmailCommandHandler(CredsDbContext credsContext)
        {
            _credsContext = credsContext;
        }
        public async Task<string> Handle(RegisterEmailCommand request, CancellationToken cancellationToken)
        {
            if (!RegisterEmailValidation.EmailSame(request.Dto))
            {
                return "The emails don't match with each other";
            }

            var result = await _credsContext.userCreds.SingleOrDefaultAsync(x => x.Email == request.Dto.EmailEntered);

            if (result is not null)
            {
                if(result.SoftDeleted)
                {
                    result.Email = request.Dto.EmailEntered;
                    result.SoftDeleted = false;
                    result.EmailEnteredTime = DateTime.UtcNow;
                }
                else
                {
                    return "Your email already exists in our database";
                }
            }
            result = new UserCreds
            {
                Email = request.Dto.EmailEntered,
                SoftDeleted = false,
                EmailEnteredTime = DateTime.UtcNow
            };

            await _credsContext.SaveChangesAsync(cancellationToken);
            return "COMPLETED";
        }
    }
}
