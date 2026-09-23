//using Microsoft.AspNetCore.Mvc;

//namespace WebAPI.Controllers
//{
//    [ApiController]
//    [Route("api/users/[controller]")]
//    public class UsersController: ControllerBase
//    {
//        [HttpGet]
//        public IActionResult GetAllUsers()
//        {
//            return Ok("Get Users!");
//        }

//        [HttpGet("city")]
//        public IActionResult GetUsers(string city)
//        {
//            return Ok($"City: {city}");
//        }

//        [HttpGet]
//        [Route("{id}")]
//        public IActionResult GetUserById(int id)
//        {
//            return Ok($"Get user {id}");
//        }

//        [HttpPost]
//        public IActionResult AddUser()
//        {
//            return Ok("User created");
//        }

//        [HttpPut]
//        [Route("{id}")]
//        public IActionResult UpdateUser(int id)
//        {
//            return Ok($"User {id} updated");
//        }
//        [HttpPatch("{id}")]
//        public IActionResult PartialUpdateUser(int id)
//        {
//            return Ok($"User {id} partially updated");
//        }

//        [HttpDelete("{id}")]
//        public IActionResult DeleteUser(int id)
//        {
//            return Ok($"User {id} deleted");
//        }
//    }
//}
