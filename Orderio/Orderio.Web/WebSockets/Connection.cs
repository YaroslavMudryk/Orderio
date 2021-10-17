using System;
using System.Net.WebSockets;

namespace Orderio.Web.WebSockets
{
    public class Connection
    {
        public WebSocket WebSocket { get; set; }
        public DateTime ConnectedAt { get; set; }
        public string AccessToken { get; set; }
    }
}