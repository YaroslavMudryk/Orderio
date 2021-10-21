using System;
using System.ComponentModel.DataAnnotations;

namespace Orderio.Domain.Models
{
    public class Notification : BaseModel<Guid>
    {
        [Required, StringLength(150, MinimumLength = 5)]
        public string Title { get; set; }
        [Required, StringLength(3000, MinimumLength = 10)]
        public string Description { get; set; }
        [Required]
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public string Payload { get; set; }
        public bool IsImportant { get; set; }
        public NotificationType Type { get; set; }
        public string Icon { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}