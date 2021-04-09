using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Repository
{
    public class UserContext : DbContext
    {
        private Random gen = new Random();

        private IEnumerable<User> CreateInitialData()
        {
            return Enumerable.Range(1, 60).Select(i =>
                    {
                        var dateReg = new DateTime(2021, 4, gen.Next(1, 30));
                        var dateLastActivity = new DateTime(2021, 4, gen.Next(dateReg.Day, 30));
                        return new User
                        {
                            UserId = i,
                            DateLastActivity = dateLastActivity,
                            DateRegistration = dateReg
                        };
                    }
                );
        }

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=pass");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<User>()
                .HasData(CreateInitialData());
        }
    }
}
