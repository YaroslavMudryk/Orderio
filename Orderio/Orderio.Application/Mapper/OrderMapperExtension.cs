using Orderio.Application.ViewModels.Orders;
using Orderio.Application.ViewModels.Products;
using Orderio.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Orderio.Application.Mapper
{
    public static class OrderMapperExtension
    {
        public static OrderViewModel ToOrderView(this Order order)
        {
            if (order == null)
                return null;
            return new OrderViewModel
            {
                Id = order.Id,
                CreatedAt = order.CreatedAt,
                Price = order.Price,
                Quantity = order.Quantity,
                Statuses = order.OrderStatuses.ToStatusesView(),
                Product = JsonSerializer.Deserialize<ProductViewModel>(order.Product),
                Department = order.Department.ToDepartmentView(),
                User = order.User.ToUserView()
            };
        }

        public static List<OrderShortViewModel> ToOrdersView(this IEnumerable<Order> orders)
        {
            if (orders == null || orders.Count() == 0)
                return null;

            return orders.Select(x => new OrderShortViewModel
            {
                Id = x.Id,
                CreatedAt = x.CreatedAt,
                Price = x.Price,
                Quantity = x.Quantity,
                Product = JsonSerializer.Deserialize<ProductViewModel>(x.Product),
                CurrentStatus = x.OrderStatuses.ToCurrentStatus(x.CurrentStatusId)
            }).ToList();
        }
    }
}