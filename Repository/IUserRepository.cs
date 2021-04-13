using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();

        void Save();
        void UpdateUser(User user);
        void UpdateUsers(IEnumerable<User> users);
        void AddUser();
        void DeleteUser(int userId);
        int Get7DayRollingRetention();
        IEnumerable<UsersLifetime> GetUsersLifetime();
    }
}
