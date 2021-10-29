using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Orderio.Application.Services.Intefaces;
using System.Threading.Tasks;

namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    public class UsersController : ApiBaseController
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public IActionResult GetMe()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetUserByIdAsync(int id)
        {
            var result = await _userService.GetUserByIdAsync(id);
            if (result.IsSuccessed)
                return Ok(result.Data);
            return NotFound(result.Error);
        }

        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }
    }
}
