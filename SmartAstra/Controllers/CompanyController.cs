using Microsoft.AspNetCore.Mvc;
using SmartAstra.Business;
using SmartAstra.Entities;
using SmartAstra.Framework.Entities.Interfaces;

namespace SmartAstra.Api.Controllers
{
    [ApiController]
    [Route("api/Company")]
    public class CompanyController : Controller
    {
        private CompanyBusiness _companyBusiness;
        public CompanyController()
        {
            _companyBusiness = new CompanyBusiness();
        }

        [HttpGet()]
        [Route("All")]
        public IActionResult GetAllCompanies()
        {
            var result = _companyBusiness.GetCompanies();
            return Ok(result);
        }


        [HttpGet()]
        public IActionResult GetCompany(IRequest<Company> request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            var result = _companyBusiness.GetCompany(request.Data.Id);
            return Ok(result);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(IRequest<Company> request)
        {
            if (request == null || string.IsNullOrEmpty(request.Data.Name))
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(IRequest<Company> request)
        {
            if (request == null || string.IsNullOrEmpty(request.Data.Name) || request.Data.Id == 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
