using Orderio.Application.ViewModels.Orders;
using Orderio.Shared;
using System.Threading.Tasks;

namespace Orderio.Application.Services.Intefaces
{
    public interface IOrderService
    {
        Task<IResult<PagedList<OrderShortViewModel>>> GetUserOrdersAsync(int userId, int page = 1);
        Task<IResult<PagedList<OrderShortViewModel>>> GetDepartmentOrdersAsync(int departmentId, int page = 1);
        Task<IResult<OrderViewModel>> GetOrderByIdAsync(int userId, long orderId);
    }
}