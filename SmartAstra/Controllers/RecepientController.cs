using Microsoft.AspNetCore.Mvc;
using SmartAstra.Entities;
using SmartAstra.Framework.Entities.Interfaces;
using System.Collections.Generic;

namespace SmartAstra.Api.Controllers
{
    [ApiController]
    [Route("Api/Recepient")]
    public class RecepientController : Controller
    {

        #region Recepient

        [HttpGet]
        [Route("All")]
        public IActionResult GetRecepients(IRequest<Recepient> request)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetRecepientById(IRequest<Recepient> request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            return Ok();


        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Insert(IRequest<Recepient> request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            return Ok();
        }


        [HttpPut]
        [Route("Update")]
        public IActionResult Update(IRequest<Recepient> request)
        {
            if (request == null || request.Data.Id == 0)
            {
                return BadRequest();
            }

            return Ok();
        }


        #endregion

        #region Recepient List

        [HttpGet]
        [Route("List/All")]
        public IActionResult GetRecepientLists()
        {
            return Ok();
        }

        [HttpGet]
        [Route("List/{id}")]
        public IActionResult GetRecepientList(IRequest<IList<Recepient>> request)
        {
            if (request == null || request.Data.Count == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPost]
        [Route("List/Add")]
        public IActionResult InsertRecepientList(IRequest<IList<Recepient>> request)
        {
            if (request == null || request.Data.Count == 0)
            {
                return BadRequest();
            }

            return Ok();
        }


        [HttpPut]
        [Route("List/Update")]
        public IActionResult UpdateRecepientList(IRequest<IList<Recepient>> request)
        {
            if (request == null || request.Data.Count == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        #endregion
    }
}
