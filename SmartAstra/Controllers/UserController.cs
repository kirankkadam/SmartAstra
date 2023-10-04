using Microsoft.AspNetCore.Mvc;
using SmartAstra.Entities;
using SmartAstra.Framework.Entities.Interfaces;

namespace SmartAstra.Api.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(IRequest<User> request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpGet]
        public IActionResult GetUsers(IRequest<User> request)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Insert(IRequest<User> request)
        {
            if (request == null || string.IsNullOrEmpty(request.Data.FirstName)
                || string.IsNullOrEmpty(request.Data.LastName)
                || string.IsNullOrEmpty(request.Data.Email))
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(IRequest<User> request)
        {
            if (request == null || request.Data.Id == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
