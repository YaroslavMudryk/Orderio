using System.ComponentModel.DataAnnotations;

namespace Orderio.Application.ViewModels.Departments
{
    public class LocationViewModel
    {
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
    }
}
