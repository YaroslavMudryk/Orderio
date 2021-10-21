using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Orderio.Domain.Models
{
    public class User : BaseModel<int>
    {
        [Required, StringLength(150, MinimumLength = 2)]
        public string FullName { get; set; }
        [Required, StringLength(20, MinimumLength = 3)]
        public string UserName { get; set; }
        [StringLength(500, MinimumLength = 5)]
        public string Photo { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public List<UserLogin> UserLogins { get; set; }
    }
}