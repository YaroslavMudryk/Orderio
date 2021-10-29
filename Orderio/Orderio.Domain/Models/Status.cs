using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Orderio.Domain.Models
{
    public class Status : BaseModel<int>
    {
        [Required, StringLength(500, MinimumLength = 2)]
        public string Name { get; set; }
        [Required, StringLength(100, MinimumLength = 1)]
        public string Colour { get; set; } //color in hex format
        [Required]
        public bool CanCancelOrder { get; set; }
        [StringLength(500, MinimumLength = 2)]
        public string NameEng { get; set; }
        [StringLength(1000, MinimumLength = 5)]
        public string Description { get; set; }
        public List<OrderStatus> OrderStatuses { get; set; }
    }
}