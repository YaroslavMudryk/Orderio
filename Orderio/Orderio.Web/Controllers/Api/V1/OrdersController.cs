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

        [HttpGet("{id}")]
        public IActionResult GetOrderById(long id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult CancelOrder(long id, string reason)
        {
            if (string.IsNullOrWhiteSpace(reason))
                return BadRequest();
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateOrder()
        {
            return Ok();
        }

        [HttpGet("statuses")]
        public IActionResult GetAllStatuses()
        {
            return Ok();
        }

        [HttpPatch("{id}/status")]
        public IActionResult UpdateOrderStatus(long id, int statusId)
        {
            return Ok();
        }

        [HttpGet("departments/{id}")]
        public IActionResult GetDepartmentsOrder(int id, int page = 1)
        {
            return Ok();
        }
    }
}