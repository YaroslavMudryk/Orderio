using DeviceDetectorNET;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Orderio.Web.AppStart;
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
        protected ClientInfo GetClientInfo(string ua = null)
        {
            DeviceDetector dd;
            OS osModel = null;
            Browser browserModel = null;
            if (string.IsNullOrEmpty(ua))
            {
                var userAgent = GetUserAgent();
                dd = new DeviceDetector(userAgent);
            }
            else
            {
                dd = new DeviceDetector(ua);
            }
            dd.SkipBotDetection();
            dd.Parse();
            var os = dd.GetOs().Match;
            if (os != null)
                osModel = new OS
                {
                    Name = GetStringOrNull(os.Name),
                    Version = GetStringOrNull(os.Version),
                    Platform = GetStringOrNull(os.Platform)
                };
            var browser = dd.GetBrowserClient().Match;
            if (browser != null)
                browserModel = new Browser
                {
                    Name = GetStringOrNull(browser.Name),
                    Version = GetStringOrNull(browser.Version),
                    Engine = GetStringOrNull(browser.Engine),
                    Type = GetStringOrNull(browser.Type)
                };
            return new ClientInfo
            {
                Device = new Device
                {
                    Brand = GetStringOrNull(dd.GetBrandName()),
                    Model = GetStringOrNull(dd.GetModel()),
                    Type = GetStringOrNull(dd.GetDeviceName())
                },
                OS = osModel,
                Browser = browserModel
            };
        }

        private string GetStringOrNull(string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;
            return value;
        }
    }
}