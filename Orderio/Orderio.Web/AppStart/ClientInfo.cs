using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderio.Web.AppStart
{
    public class ClientInfo
    {
        public Browser Browser { get; set; }
        public Device Device { get; set; }
        public OS OS { get; set; }
    }
    public class Device
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
    }
    public class Browser
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Engine { get; set; }
        public string Type { get; set; }
    }
    public class OS
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Platform { get; set; }
    }
}
