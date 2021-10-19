using Microsoft.AspNetCore.Mvc;
using System;
namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    public class NotificationsController : ApiBaseController
    {
        [HttpGet]
        public IActionResult GetNotifications(int page = 1)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult ReadNotification(Guid? id)
        {
            return Ok();
        }
    }
}