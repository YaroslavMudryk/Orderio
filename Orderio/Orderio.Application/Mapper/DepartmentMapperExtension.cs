using Orderio.Application.ViewModels.Departments;
using Orderio.Domain.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace Orderio.Application.Mapper
{
    public static class DepartmentMapperExtension
    {
        public static DepartmentViewModel ToDepartmentView(this Department department)
        {
            if (department == null)
                return null;
            return new DepartmentViewModel
            {
                Id = department.Id,
                CreatedAt = department.CreatedAt,
                Name = department.Name,
                Image = department.Image,
                Address = department.Address,
                Location = JsonSerializer.Deserialize<LocationViewModel>(department.Location),
                WorkTime = JsonSerializer.Deserialize<List<WorkTimeViewModel>>(department.WorkTime)
            };
        } 
    }
}