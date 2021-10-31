using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Orderio.Application.Services.Intefaces;
using System.Threading.Tasks;

namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    [AllowAnonymous]
    public class UsersController : ApiBaseController
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsersAsync(int page = 1)
        {
            var result = await _userService.GetUsersAsync(page);
            if (result.IsSuccessed)
                return Ok(result.Data);
            return NotFound(result.Error);
        }

        [HttpGet("me")]
        public async Task<IActionResult> GetMeAsync()
        {
            var result = await _userService.GetMeAsync();
            if (result.IsSuccessed)
                return Ok(result.Data);
            return NotFound(result.Error);
        }

        [HttpGet("{id}")]
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
