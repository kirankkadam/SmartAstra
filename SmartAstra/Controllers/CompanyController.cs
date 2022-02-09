using Microsoft.AspNetCore.Mvc;
using SmartAstra.Business;
using SmartAstra.Entities;

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
        public IActionResult GetAllCompanies()
        {
            var result = _companyBusiness.GetCompanies();
            return Ok(result);
        }


        [HttpGet()]
        [Route("{id}")]
        public IActionResult GetCompany(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var result = _companyBusiness.GetCompany(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add(Company company)
        {
            if (company == null || string.IsNullOrEmpty(company.Name))
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Company company)
        {
            if (company == null || string.IsNullOrEmpty(company.Name) || company.Id == 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
