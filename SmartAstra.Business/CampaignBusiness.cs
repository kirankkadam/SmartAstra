using SmartAstra.Business.Interfaces;
using SmartAstra.Data.Interfaces;
using SmartAstra.Dto;
using SmartAstra.Framework.Common;
using SmartAstra.Framework.Entities.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SmartAstra.Business
{
    public class CampaignBusiness : IBusinessOperations
    {
        private IDataOperations<Entities.Campaign> _dbOperations;
        public CampaignBusiness()
        {
            _dbOperations = new Data.Campaign();
        }

        public IResponse<List<Dto.Campaign>> GetAllCampaigns(IRequest<Campaign> request)
        {
            var results = _dbOperations.GetAll();
            var response = new Response<List<Campaign>>();
            if (results != null)
            {
                var listOfCampaigns = new List<Dto.Campaign>();
                foreach (var campaign in results)
                {
                    var campaignDto = ConvertFromEntitiesToDto(campaign);
                    listOfCampaigns.Add(campaignDto);
                }
                response.Result = listOfCampaigns;
            }
            return response;
        }

        public IResponse<Dto.Campaign> GetCampaignById(int id)
        {
            var result = _dbOperations.Get(id);
            var response = new Response<Dto.Campaign>();
            if (result != null)
            {
                response.Result = ConvertFromEntitiesToDto(result);
            }
            return response;
        }

        public IResponse<Dto.Campaign> AddCampaign(Dto.Campaign newCampaign)
        {
            var response = new Response<Dto.Campaign>();
            if (newCampaign != null)
            {
                if (DoesCampaignNameExist(newCampaign.Name))
                {
                    response.Status = ResponseStatus.Duplicate;
                    return response;
                }

                var campaign = ConvertFromDtoToEntity(newCampaign);
                var result = _dbOperations.Insert(campaign);

                if (result != null)
                {
                    response.Result = ConvertFromEntitiesToDto(result);
                }
            }
            return response;
        }

        public IResponse<Dto.Campaign> UpdateCampaign(Dto.Campaign existingCampaign)
        {
            var response = new Response<Dto.Campaign>();
            if (existingCampaign != null)
            {
                var campaign = ConvertFromDtoToEntity(existingCampaign);
                var result = _dbOperations.Insert(campaign);

                if (result != null)
                {
                    response.Result = ConvertFromEntitiesToDto(result);
                }
            }
            return response;
        }

        #region Private methods
        private Dto.Campaign ConvertFromEntitiesToDto(Entities.Campaign campaign)
        {
            return new Dto.Campaign()
            {
                Id = campaign.Id,
                Name = campaign.Name
            };
        }

        private Entities.Campaign ConvertFromDtoToEntity(Dto.Campaign campaign)
        {
            return new Entities.Campaign()
            {
                Id = campaign.Id,
                Name = campaign.Name
            };
        }

        private bool DoesCampaignNameExist(string campaignName)
        {
            return false;
        }
        #endregion 
    }
}
