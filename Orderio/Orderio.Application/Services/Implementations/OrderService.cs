using Orderio.Application.Mapper;
using Orderio.Application.Services.Intefaces;
using Orderio.Application.ViewModels.Orders;
using Orderio.Application.ViewModels.Products;
using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.Json;
using System.Threading.Tasks;

namespace Orderio.Application.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderStatusRepository _orderStatusRepository;
        private readonly IStatusRepository _statusRepository;
        public OrderService(IOrderRepository orderRepository, IStatusRepository statusRepository, IOrderStatusRepository orderStatusRepository, IDepartmentRepository departmentRepository)
        {
            _orderRepository = orderRepository;
            _statusRepository = statusRepository;
            _orderStatusRepository = orderStatusRepository;
            _departmentRepository = departmentRepository;
        }

        public async Task<IResult<PagedList<OrderShortViewModel>>> GetDepartmentOrdersAsync(int departmentId, int page = 1, int countPerPage = 20)
        {
            return await GetOrdersAsync(x => x.DepartmentId == departmentId, page, countPerPage);
        }

        public async Task<IResult<OrderViewModel>> GetOrderByIdAsync(int userId, long orderId)
        {
            var orderFromDb = await _orderRepository.GetAsync(x => x.Id == orderId);
            if (orderFromDb is null)
                return new Result<OrderViewModel>("Order not found");
            if (orderFromDb.UserId != userId)
                return new Result<OrderViewModel>("Access denited");

            //todo add checking for employee of department

            orderFromDb.OrderStatuses = await _orderStatusRepository.GetAllOrderStatusesAsync(orderId);
            var orderToView = orderFromDb.ToOrderView();
            return new Result<OrderViewModel>(orderToView);
        }

        public async Task<IResult<PagedList<OrderShortViewModel>>> GetUserOrdersAsync(int userId, int page = 1, int countPerPage = 20)
        {
            return await GetOrdersAsync(x => x.UserId == userId, page, countPerPage);
        }

        public async Task<IResult<PagedList<OrderShortViewModel>>> GetOrdersAsync(Expression<Func<Order, bool>> expression, int page = 1, int countPerPage = 20)
        {
            var ordersFromDb = await _orderRepository.GetPagedOrdersAsync(expression, page, countPerPage);
            if (ordersFromDb.Count == 0)
                return new Result<PagedList<OrderShortViewModel>>("Oreders not found");
            var ordersToViews = ordersFromDb.Items.Select(x => new OrderShortViewModel
            {
                Id = x.Id,
                CreatedAt = x.CreatedAt,
                Price = x.Price,
                Quantity = x.Quantity,
                Product = JsonSerializer.Deserialize<ProductViewModel>(x.Product),
                CurrentStatus = _statusRepository.GetAsync(s => s.Id == x.CurrentStatusId).Result.ToShortStatusView()
            });
            var pagedList = new PagedList<OrderShortViewModel>(ordersToViews, ordersFromDb.Total, ordersFromDb.PerPage);
            return new Result<PagedList<OrderShortViewModel>>(pagedList);
        }
    }
}