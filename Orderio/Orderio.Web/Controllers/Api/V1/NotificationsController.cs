using Microsoft.AspNetCore.Mvc;
using System;
namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    public class NotificationsController : ApiBaseController
    {
        [HttpGet]
        public IActionResult GetNotifications(int flag)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult ReadNotifications(Guid? id)
        {
            return Ok();
        }
    }
}