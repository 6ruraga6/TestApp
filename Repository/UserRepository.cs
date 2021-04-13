using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _userContext;

        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public int Get7DayRollingRetention()
        {
            var dateCreate = _userContext.Users.Min(u => u.DateRegistration);
            
            var returnedUsers =
                _userContext.Users
                .Where(s =>
                    s.DateRegistration >= dateCreate &&
                    s.DateRegistration <= dateCreate.AddDays(7) &&
                    s.DateLastActivity >= dateCreate.AddDays(7));
            var registeredUsers =
                _userContext.Users
                .Where(u =>
                    u.DateRegistration >= dateCreate &&
                    u.DateRegistration <= dateCreate.AddDays(7)
                );

            return (int)((float)returnedUsers.Count() / registeredUsers.Count() * 100);
        }

        public IEnumerable<UsersLifetime> GetUsersLifetime()
        {
            var dateCreate = _userContext.Users.Min(u => u.DateRegistration);

            return _userContext.Users
                    .AsEnumerable()
                    .GroupBy(u => (u.DateLastActivity - u.DateRegistration).Days)
                    .Select(g => new UsersLifetime { 
                        Days = g.Key,
                        UsersCount = g.Distinct().Count()
                    })
                    .OrderBy(u => u.Days);
        }

        public IEnumerable<User> GetUsers()
        {
            return _userContext.Users.OrderBy(u => u.UserId).ToList();
        }

        public void Save()
        {
            _userContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _userContext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }

        public void UpdateUsers(IEnumerable<User> users)
        {
            _userContext.UpdateRange(users);
            Save();
        }

        public void AddUser()
        {
            var user = new User
            {
                DateLastActivity = DateTime.Now.Date,
                DateRegistration = DateTime.Now.Date
            };

            _userContext.Add(user);
            Save();
        }

        public void DeleteUser(int userId)
        {
            _userContext.Remove(_userContext.Users.FirstOrDefault(u => u.UserId == userId));
            Save();
        }
    }
}
