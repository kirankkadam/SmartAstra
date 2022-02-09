using Microsoft.AspNetCore.Mvc;
using SmartAstra.Business;
using SmartAstra.Framework.Controllers;

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
        public IActionResult GetCampaigns()
        {
            var result = _campaignBusiness.GetAllCampaigns();
            return Ok(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetCampaign(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var result = _campaignBusiness.GetCampaignById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Insert(Dto.Campaign campaign)
        {
            if (campaign == null)
            {
                return BadRequest();
            }

            if (string.IsNullOrEmpty(campaign.Name))
            {
                return BadRequest();
            }
            var result = _campaignBusiness.AddCampaign(campaign);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update(Dto.Campaign campaign)
        {
            if (campaign == null)
            {
                return BadRequest();
            }

            if (string.IsNullOrEmpty(campaign.Name))
            {
                return BadRequest();
            }
            var result = _campaignBusiness.UpdateCampaign(campaign);
            return Ok(result);
        }

    }
}
