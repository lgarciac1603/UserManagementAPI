using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;
using UserManagementAPI.Services;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _service;

        public UsersController(UserService service)
        {
            _service = service;
        }

        // GET api/users
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        // GET api/users/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _service.GetById(id);
            if (user == null) return NotFound(new { error = "User not found" });
            return Ok(user);
        }

        // POST api/users
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Name) || !user.Email.Contains("@"))
                return BadRequest(new { error = "Invalid user data" });

            user.Id = new Random().Next(1, 10000); // simulando DB
            _service.Add(user);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        // PUT api/users/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, User updatedUser)
        {
            if (string.IsNullOrWhiteSpace(updatedUser.Name) || !updatedUser.Email.Contains("@"))
                return BadRequest(new { error = "Invalid user data" });

            var updated = _service.Update(id, updatedUser);
            if (!updated) return NotFound(new { error = "User not found" });
            return NoContent();
        }

        // DELETE api/users/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _service.Delete(id);
            if (!deleted) return NotFound(new { error = "User not found" });
            return NoContent();
        }
    }
}
