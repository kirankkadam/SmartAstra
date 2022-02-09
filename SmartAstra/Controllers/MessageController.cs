using Microsoft.AspNetCore.Mvc;
using SmartAstra.Entities;

namespace SmartAstra.Api.Controllers
{
    [ApiController]
    [Route("Api/Message")]
    public class MessageController : Controller
    {

        [HttpGet]
        public IActionResult GetMessages()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetMessage(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return Ok();
        }


        [HttpPost]
        [Route("Insert")]
        public IActionResult Insert(Message message)
        {
            if (message == null)
            {
                return BadRequest();
            }
            if (string.IsNullOrEmpty(message.Name))
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Message message)
        {
            if (message == null)
            {
                return BadRequest();
            }
            if (string.IsNullOrEmpty(message.Name) || message.Id == 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
