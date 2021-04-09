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
        public IEnumerable<RollingRetentionItem> GetRollingRetention()
        {
            return _userRepository.GetRollingRetention(DateTime.Now, 7);
        }

        [HttpPut]
        public ActionResult Put(IEnumerable<User> users)
        {
            _userRepository.UpdateUsers(users);

            return Ok();
        }
    }
}
