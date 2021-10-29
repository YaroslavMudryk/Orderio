using Orderio.Application.ViewModels.Users;
using System.Threading.Tasks;

namespace Orderio.Application.Services.Intefaces
{
    public interface IUserService
    {
        Task<IResult<UserViewModel>> GetUserByIdAsync(int id);
    }
}
