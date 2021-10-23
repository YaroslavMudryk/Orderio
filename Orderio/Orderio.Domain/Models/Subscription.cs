using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orderio.Domain.Models
{
    public class Subscription : BaseModel<int>
    {
        [Required, StringLength(250, MinimumLength = 5)]
        public string Title { get; set; }
        [Required]
        public double Amount { get; set; }
        [StringLength(2500, MinimumLength = 10)]
        public string Description { get; set; }
        [Column(TypeName = "bigint")]
        public TimeSpan Interval { get; set; }
        [StringLength(1250, MinimumLength = 10)]
        public string Image { get; set; }
    }
}