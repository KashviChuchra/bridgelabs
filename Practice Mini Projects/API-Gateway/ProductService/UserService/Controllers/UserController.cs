using System.Collections.Generic;
using UserModelLayer;
using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<UserModel>()
            {
                new UserModel { Id = 1, Name = "Kashvi"},
                new UserModel { Id = 2, Name = "Hargun"},
                new UserModel { Id = 3, Name = "Nupur"}
            };
            return Ok(users);
        }
    }
}
