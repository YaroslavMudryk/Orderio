using Orderio.Application.Mapper;
using Orderio.Application.Services.Intefaces;
using Orderio.Application.ViewModels.Orders;
using Orderio.Domain.Interfaces;
using Orderio.Shared;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IResult<PagedList<OrderShortViewModel>>> GetDepartmentOrdersAsync(int departmentId, int page = 1)
        {
            throw new System.NotImplementedException();
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

        public async Task<IResult<PagedList<OrderShortViewModel>>> GetUserOrdersAsync(int userId, int page = 1)
        {
            var ordersFromDb = await _orderRepository.GetPagedOrdersAsync(x => x.UserId == userId, page);
            if (ordersFromDb == null || ordersFromDb.Count == 0)
                return new Result<PagedList<OrderShortViewModel>>("Orders not found");

            var orders = ordersFromDb.Items;

            var ordersToView = orders.ToOrdersView();

            var pagedListResult = new PagedList<OrderShortViewModel>(orders, ordersFromDb.Total, ordersFromDb.CurrentPage, ordersFromDb.PerPage);

            return new Result<PagedList<OrderShortViewModel>>();
        }
    }
}
