using System;

namespace Orderio.Application.ViewModels.Users
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Photo { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }
}