using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Orderio.Domain.Models
{
    public class Department : BaseModel<int>
    {
        [Required, StringLength(300, MinimumLength = 10)]
        public string Name { get; set; }
        [StringLength(1500, MinimumLength = 5)]
        public string Image { get; set; }
        [StringLength(500, MinimumLength = 5)]
        public string Address { get; set; }
        [StringLength(1500, MinimumLength = 2)]
        public string WorkTime { get; set; } //json object (list of work day)
        public string Location { get; set; } //json object (like address, lon, lat)
        public List<Product> Products { get; set; }
    }
}