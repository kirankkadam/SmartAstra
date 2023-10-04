using Microsoft.AspNetCore.Mvc;
using SmartAstra.Business;
using SmartAstra.Dto;
using SmartAstra.Framework.Controllers;
using SmartAstra.Framework.Entities.Interfaces;

namespace SmartAstra.Api.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/Campaign")]
    public class CampaignController : BaseController<Dto.Campaign>
    {
        private CampaignBusiness _campaignBusiness;
        public CampaignController()
        {
            _campaignBusiness = new CampaignBusiness();
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetCampaigns(IRequest<Campaign> request)
        {
            var result = _campaignBusiness.GetAllCampaigns(request);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetCampaign(IRequest<Campaign> request)
        {
            if (request == null && request.Data.Id == 0)
            {
                return BadRequest();
            }
            var result = _campaignBusiness.GetCampaignById(request.Data.Id);
            return Ok(result);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Insert(IRequest<Campaign> request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            if (string.IsNullOrEmpty(request.Data.Name))
            {
                return BadRequest();
            }
            var result = _campaignBusiness.AddCampaign(request.Data);
            return Ok(result);
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(IRequest<Campaign> request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            if (string.IsNullOrEmpty(request.Data.Name))
            {
                return BadRequest();
            }
            var result = _campaignBusiness.UpdateCampaign(request.Data);
            return Ok(result);
        }

    }
}
