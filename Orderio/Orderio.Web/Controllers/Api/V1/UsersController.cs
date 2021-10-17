using DeviceDetectorNET;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    public class UsersController : ApiBaseController
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetMe(string q)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult GetUserById(int id)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }
    }
}
