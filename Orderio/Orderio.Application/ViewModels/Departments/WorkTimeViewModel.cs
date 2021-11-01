using System;
using System.ComponentModel.DataAnnotations;

namespace Orderio.Application.ViewModels.Departments
{
    public class WorkTimeViewModel
    {
        [Required]
        public DateTime From { get; set; }
        [Required]
        public DateTime To { get; set; }
        [Required]
        public DayOfWeek DayOfWeek { get; set; }
        [Required]
        public bool IsWeekend { get; set; }
    }
}
