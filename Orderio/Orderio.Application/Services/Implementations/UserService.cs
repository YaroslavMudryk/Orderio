using Orderio.Application.Services.Intefaces;
using Orderio.Application.ViewModels.Users;
using Orderio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task<IResult<UserViewModel>> GetUserByIdAsync(int id)
        {
            var userFromDb = await _userRepository.GetAsync(x => x.Id == id);
            if (userFromDb == null)
                return new Result<UserViewModel>("User not found");
            var userToView = new UserViewModel
            {
                Id = userFromDb.Id,
                FullName = userFromDb.FullName,
                UserName = userFromDb.UserName,
                Photo = userFromDb.Photo
            };
            return new Result<UserViewModel>(userToView);
        }
    }
}
