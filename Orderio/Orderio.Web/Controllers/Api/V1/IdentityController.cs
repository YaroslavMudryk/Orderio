using Microsoft.AspNetCore.Mvc;
namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    public class IdentityController : ApiBaseController
    {
        [HttpPost("register")]
        public IActionResult RegisterUser()
        {
            return Ok();
        }

        [HttpPost("login")]
        public IActionResult LoginUser()
        {
            return Ok();
        }

        [HttpPost("logout")]
        public IActionResult LogoutUser()
        {
            return Ok();
        }
    }
}