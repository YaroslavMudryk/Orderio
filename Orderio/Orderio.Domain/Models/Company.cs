using System.ComponentModel.DataAnnotations;
namespace Orderio.Domain.Models
{
    public class Company : BaseModel<int>
    {
        [Required, StringLength(300, MinimumLength = 10)]
        public string Name { get; set; }
        [StringLength(5000, MinimumLength = 5)]
        public string Description { get; set; }
        [StringLength(1500, MinimumLength = 5)]
        public string Image { get; set; }
        [StringLength(500, MinimumLength = 5), Url]
        public string SiteAddress { get; set; }
        [StringLength(10000, MinimumLength = 10)]
        public string History { get; set; }
        [StringLength(15, MinimumLength = 1)]
        public string TotalEmployees { get; set; }
        [StringLength(150, MinimumLength = 5)]
        public string EmailAddress { get; set; }
        [StringLength(100, MinimumLength = 3)]
        public string Phone { get; set; }
        [StringLength(10000, MinimumLength = 1)]
        public string AdditionalInfo { get; set; }
    }
}