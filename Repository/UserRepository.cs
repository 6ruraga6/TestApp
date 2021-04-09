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

        public IEnumerable<RollingRetentionItem> GetRollingRetention(DateTime dateBegin, int daysCount)
        {
            var regCounts =
                _userContext.Users
                    .GroupBy(u => u.DateRegistration)
                    .Select(g => new RegCount { RegDate = g.Key, Count = g.Distinct().Count() })
                    .Where(s => s.RegDate > dateBegin && s.RegDate <= dateBegin.AddDays(daysCount))
                    .ToList();
            var dateDiffCounts =
                _userContext.Users.AsEnumerable()
                    .GroupBy(u => new { RegDate = u.DateRegistration, DateDiff = (u.DateLastActivity - u.DateRegistration).TotalDays })
                    .Select(g => new DateDiffCount { RegDate = g.Key.RegDate, DateDiff = (int)g.Key.DateDiff, Count = g.Distinct().Count() })
                    .Where(s => s.RegDate > dateBegin && s.RegDate <= dateBegin.AddDays(daysCount) && s.DateDiff >= 0 && s.DateDiff <= daysCount)
                    .ToList();

            return
                (from rc in regCounts
                join ddc in dateDiffCounts on rc.RegDate equals ddc.RegDate
                select new {rc.Count, Count1 = ddc.Count, ddc.DateDiff})
                .GroupBy(i => i.DateDiff)
                .Select(g => new RollingRetentionItem
                {
                    DateDiff = (int)g.Key,
                    Days = (int)g.Average(i => i.Count),
                    RetentionBase = (int)g.Average(i => i.Count1),
                    RetentionRate = (int)(g.Average(i => i.Count1) / g.Average(i => i.Count) * 100)
                })
                .OrderBy(i => i.DateDiff)
                .ToList();
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
    }
}
