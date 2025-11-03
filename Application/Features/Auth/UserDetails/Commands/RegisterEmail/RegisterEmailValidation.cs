using AuthenticationAndAuthorization.Application.Features.Auth.UserDetails.Models;

namespace AuthenticationAndAuthorization.Application.Features.Auth.UserDetails.Commands.RegisterEmail
{
    public static class RegisterEmailValidation
    {
        public static Func<RegisterEmailDto, bool> EmailSame = e => (e.EmailEntered == e.ReEmailReentered) ? true : false;
    }
}
