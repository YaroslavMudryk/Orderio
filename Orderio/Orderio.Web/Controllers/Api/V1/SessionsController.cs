using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    public class SessionsController : ApiBaseController
    {
        [HttpGet]
        public IActionResult GetSessions(int q)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetUserSession(Guid id)
        {
            return Ok();
        }

        [HttpDelete]
        [AllowAnonymous]
        public IActionResult CloseSessions(Guid? id, int q)
        {
            return Ok();
        }
    }
}
