using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository;
using Models;

namespace TestApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UsersController> _logger;

        public UsersController(IUserRepository userRepository, ILogger<UsersController> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userRepository.GetUsers();
        }

        [HttpGet("/rollingretention")]
        public int Get7DayRollingRetention()
        {
            return _userRepository.Get7DayRollingRetention();
        }

        [HttpGet("/userslifetime")]
        public IEnumerable<UsersLifetime> GetUsersLifetime()
        {
            return _userRepository.GetUsersLifetime();
        }

        [HttpPut]
        public ActionResult Put(IEnumerable<User> users)
        {
            _userRepository.UpdateUsers(users);

            return Ok();
        }

        [HttpPost]
        public ActionResult Post()
        {
            _userRepository.AddUser();

            return RedirectToAction("Get");
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute(Name = "id")] int userId)
        {
            Console.WriteLine(userId);

            _userRepository.DeleteUser(userId);

            return Ok();
        }
    }
}
