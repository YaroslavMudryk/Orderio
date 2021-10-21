using System;
using System.ComponentModel.DataAnnotations;
namespace Orderio.Domain.Models
{
    public class Session : BaseModel<Guid>
    {
        [Required]
        public bool IsActive { get; set; }
        [StringLength(3500, MinimumLength = 5)]
        public string Token { get; set; }
        public DateTime? DateUnActive { get; set; }
        [Required, StringLength(50, MinimumLength = 3)]
        public string DeviceType { get; set; } // mobile, desktop, web
        [StringLength(100)]
        public string Device { get; set; } // device name, model
        [StringLength(150)]
        public string Platform { get; set; } // OS + Version
        public string Claims { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string IP { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}