using Microsoft.AspNetCore.Mvc;
using SmartAstra.Entities;
using SmartAstra.Framework.Entities.Interfaces;

namespace SmartAstra.Api.Controllers
{
    [ApiController]
    [Route("Api/Message")]
    public class MessageController : Controller
    {

        [HttpGet]
        [Route("All")]
        public IActionResult GetMessages()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetMessage(IRequest<Message> request)
        {
            if (request == null)
            {
                return BadRequest(string.Empty);
            }
            return Ok();
        }


        [HttpPost]
        [Route("Add")]
        public IActionResult Insert(IRequest<Message> request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            if (string.IsNullOrEmpty(request.Data.Name))
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(IRequest<Message> request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            if (string.IsNullOrEmpty(request.Data.Name) || request.Data.Id == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPost]
        [Route("Send")]
        public IActionResult SendMessages(IRequest<Message> request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            if (string.IsNullOrEmpty(request.Data.Name) || request.Data.Id == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
