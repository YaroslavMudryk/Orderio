using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    public class UsersController : ApiBaseController
    {
        [HttpGet]
        public IActionResult GetMe()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Administrator")]
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
