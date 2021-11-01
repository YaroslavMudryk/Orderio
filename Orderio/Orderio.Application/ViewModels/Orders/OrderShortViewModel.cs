using Orderio.Application.ViewModels.Products;
using System;
namespace Orderio.Application.ViewModels.Orders
{
    public class OrderShortViewModel
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public ProductViewModel Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public StatusShortViewModel CurrentStatus { get; set; }
    }
}