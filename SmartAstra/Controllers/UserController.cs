using Microsoft.AspNetCore.Mvc;
using SmartAstra.Entities;

namespace SmartAstra.Api.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Insert(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(User user)
        {
            if (user == null || user.Id == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
