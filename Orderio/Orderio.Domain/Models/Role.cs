using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Orderio.Domain.Models
{
    public class Role : BaseModel<int>
    {
        [Required, StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}