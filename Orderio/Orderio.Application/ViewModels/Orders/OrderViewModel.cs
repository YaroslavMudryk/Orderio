using Orderio.Application.ViewModels.Departments;
using Orderio.Application.ViewModels.Products;
using Orderio.Application.ViewModels.Users;
using System;
using System.Collections.Generic;

namespace Orderio.Application.ViewModels.Orders
{
    public class OrderViewModel
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public ProductViewModel Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public List<StatusViewModel> Statuses { get; set; }
        public DepartmentViewModel Department { get; set; }
        public UserViewModel User { get; set; }
    }
}
