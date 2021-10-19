using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

namespace Orderio.Web.Controllers.Api
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [Authorize]
    public class ApiBaseController : ControllerBase
    {
        protected string GetUserAgent() => HttpContext.Request.Headers["User-Agent"];
        protected string GetUserIpAddress() => HttpContext.Connection.RemoteIpAddress.ToString();
        protected string GetUserRole() => HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role).Value;
        protected int GetUserId() => Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Sub").Value);
    }
}