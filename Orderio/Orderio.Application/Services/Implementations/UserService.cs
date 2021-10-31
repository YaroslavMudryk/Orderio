using Orderio.Application.Mapper;
using Orderio.Application.Services.Intefaces;
using Orderio.Application.ViewModels.Users;
using Orderio.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orderio.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IResult<UserViewModel>> GetMeAsync()
        {
            var me = await _userRepository.GetAsync(x => x.Id == 1);
            if (me == null)
                return new Result<UserViewModel>("Not found");
            return new Result<UserViewModel>(me.ToUserView());
        }

        public async Task<IResult<UserShortViewModel>> GetUserByIdAsync(int id)
        {
            var userFromDb = await _userRepository.GetAsync(x => x.Id == id);
            if (userFromDb == null)
                return new Result<UserShortViewModel>("User not found");
            return new Result<UserShortViewModel>(userFromDb.ToShortUserView());
        }

        public async Task<IResult<List<UserShortViewModel>>> GetUsersAsync(int page = 1)
        {
            var usersFromDb = await _userRepository.GetAllAsync();
            if (usersFromDb == null || usersFromDb.Count == 0)
                return new Result<List<UserShortViewModel>>("Users not found");
            return new Result<List<UserShortViewModel>>(usersFromDb.ToShortUsersView());
        }
    }
}
