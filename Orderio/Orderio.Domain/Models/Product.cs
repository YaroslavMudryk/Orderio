using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orderio.Domain.Models
{
    public class Product : BaseModel<long>
    {
        [Required, StringLength(300, MinimumLength = 10)]
        public string Name { get; set; }
        [StringLength(1500, MinimumLength = 5)]
        public string Image { get; set; }
        [StringLength(500, MinimumLength = 2)]
        public string Description { get; set; }
        [Required, Column(TypeName = "decimal(9, 2)")]
        public decimal Price { get; set; }
    }
}