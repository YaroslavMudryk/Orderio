using Orderio.Application.ViewModels.Users;
using Orderio.Domain.Models;
using System.Collections.Generic;
using System.Linq;
namespace Orderio.Application.Mapper
{
    public static class UserMapperExtension
    {
        public static UserShortViewModel ToShortUserView(this User user)
        {
            if (user is null)
                return null;
            return new UserShortViewModel
            {
                Id = user.Id,
                FullName = user.FullName,
                UserName = user.UserName,
                Photo = user.Photo
            };
        }
        public static List<UserShortViewModel> ToShortUsersView(this IEnumerable<User> users)
        {
            if (users == null || users.Count() == 0)
                return null;
            return users.Select(x => x.ToShortUserView()).ToList();
        }


        public static UserViewModel ToUserView(this User user)
        {
            if (user == null)
                return null;
            return new UserViewModel
            {
                Id = user.Id,
                CreatedAt = user.CreatedAt,
                FullName = user.FullName,
                UserName = user.UserName,
                Photo = user.Photo,
                LastUpdatedAt = user.UpdatedAt
            };
        }
        public static List<UserViewModel> ToUsersView(this IEnumerable<User> users)
        {
            if (users == null || users.Count() == 0)
                return null;
            return users.Select(x => x.ToUserView()).ToList();
        }
    }
}