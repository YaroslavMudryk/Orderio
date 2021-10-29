using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Orderio.Domain.Models
{
    public class Status : BaseModel<int>
    {
        [Required, StringLength(500, MinimumLength = 2)]
        public string Name { get; set; }
        [StringLength(500, MinimumLength = 2)]
        public string NameEng { get; set; }
        [Required, StringLength(100, MinimumLength = 1)]
        public string Colour { get; set; } //color in hex format
        public List<OrderStatus> OrderStatuses { get; set; }
    }
}