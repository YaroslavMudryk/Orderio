using System;
using System.Collections.Generic;

namespace Orderio.Application.ViewModels.Departments
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public List<WorkTimeViewModel> WorkTime { get; set; }
        public LocationViewModel Location { get; set; }
    }
}