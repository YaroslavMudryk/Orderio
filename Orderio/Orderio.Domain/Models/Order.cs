using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Orderio.Domain.Models
{
    public class Order : BaseModel<long>
    {
        [Required, StringLength(5000, MinimumLength = 2)]
        public string Product { get; set; } // json object (copy of real product)
        [Required]
        public int Quantity { get; set; }
        [Required, Column(TypeName = "decimal(9, 2)")]
        public decimal Price { get; set; }
        public int CurrentStatusId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<OrderStatus> OrderStatuses { get; set; }
    }
}