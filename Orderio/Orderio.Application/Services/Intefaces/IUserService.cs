using Orderio.Application.ViewModels.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orderio.Application.Services.Intefaces
{
    public interface IUserService
    {
        Task<IResult<UserViewModel>> GetMeAsync();
        Task<IResult<UserShortViewModel>> GetUserByIdAsync(int id);
        Task<IResult<List<UserShortViewModel>>> GetUsersAsync(int page = 1);
    }
}
