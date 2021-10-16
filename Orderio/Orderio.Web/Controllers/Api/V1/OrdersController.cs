using Microsoft.AspNetCore.Mvc;

namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    public class OrdersController : ApiBaseController
    {
        [HttpGet]
        public IActionResult GetOrders(int page)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreatePost()
        {
            return Ok();
        }
    }
}