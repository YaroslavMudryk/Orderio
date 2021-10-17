using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    [AllowAnonymous]
    public class IdentityController : ApiBaseController
    {
        [HttpPost("register")]
        [HttpPost("sign-up")]
        public IActionResult RegisterUser()
        {
            return Ok();
        }

        [HttpPost("login")]
        [HttpPost("sign-in")]
        public IActionResult LoginUser()
        {
            return Ok(Request.Path.Value);
        }

        [HttpPost("logout")]
        [HttpPost("sign-out")]
        public IActionResult LogoutUser()
        {
            return Ok();
        }
    }
}