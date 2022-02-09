using Microsoft.AspNetCore.Mvc;
using SmartAstra.Entities;

namespace SmartAstra.Api.Controllers
{
    [ApiController]
    [Route("Api/Recepient")]
    public class RecepientController : Controller
    {

        #region Recepient

        [HttpGet]
        public IActionResult GetRecepients()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetRecepientById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            return Ok();


        }

        [HttpPost]
        [Route("Insert/Recepient")]
        public IActionResult Insert(Recepient recepient)
        {
            if (recepient == null)
            {
                return BadRequest();
            }

            return Ok();
        }


        [HttpPut]
        [Route("Update/Recepient")]
        public IActionResult Update(Recepient recepient)
        {
            if (recepient == null || recepient.Id == 0)
            {
                return BadRequest();
            }

            return Ok();
        }


        #endregion

        #region Recepient List

        [HttpGet]
        [Route("List")]
        public IActionResult GetRecepientLists()
        {
            return Ok();
        }

        [HttpGet]
        [Route("List/{id}")]
        public IActionResult GetRecepientList(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPost]
        [Route("Insert/List")]
        public IActionResult InsertRecepientList(RecepientList recepientList)
        {
            if (recepientList == null)
            {
                return BadRequest();
            }

            return Ok();
        }


        [HttpPut]
        [Route("Update/List")]
        public IActionResult UpdateRecepientList(RecepientList recepientList)
        {
            if (recepientList == null || recepientList.Id == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        #endregion
    }
}
