using DeviceDetector;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    [AllowAnonymous]
    public class IdentityController : ApiBaseController
    {
        private readonly IDetector _detector;
        public IdentityController(IDetector detector)
        {
            _detector = detector;
        }


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