using System.ComponentModel.DataAnnotations;
namespace Orderio.Domain.Models
{
    public class LoginAttempt : BaseModel<long>
    {
        [Required, MinLength(3), MaxLength(100)]
        public string Login { get; set; }
        [MinLength(5), MaxLength(2000)]
        public string Password { get; set; }
        public bool IsStatus { get; set; }
        public CauseStatus Cause { get; set; }
    }
}