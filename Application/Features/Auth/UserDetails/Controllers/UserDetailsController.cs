using AuthenticationAndAuthorization.Application.Features.Auth.UserDetails.Commands.RegisterEmail;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationAndAuthorization.Application.Features.Auth.UserDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserDetailsController (IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("RegisterEmail")]
        public async Task<IActionResult> RegisterEmail(RegisterEmailCommand cmd)
        {
            var result = await _mediator.Send(cmd);
            if(result!="COMPLETED") return BadRequest(result);
            return Ok("Your email registration was completed. Check the email for further action and password setup");
        }
    }
}
