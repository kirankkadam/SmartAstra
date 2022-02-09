using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SmartAstra.Data
{
    public class Campaign : BaseDbOperations<Entities.Campaign>
    {
        public override Entities.Campaign Delete(Entities.Campaign campaignToBeDeleted)
        {
            var campaign = AstraDbContext.Campaigns.FirstOrDefault(c => c.Id == campaignToBeDeleted.Id);
            if (campaign != null)
            {
                AstraDbContext.Campaigns.Remove(campaign);
            }
            return campaign;
        }

        public override Entities.Campaign Get(int id)
        {
            return AstraDbContext.Campaigns.AsNoTracking().FirstOrDefault(c => c.Id == id);
        }

        public override IList<Entities.Campaign> GetAll()
        {
            return AstraDbContext.Campaigns.AsNoTracking().ToList();
        }

        public override Entities.Campaign Insert(Entities.Campaign newCampaign)
        {
            lock (this)
            {
                var campaign = AstraDbContext.Campaigns.Add(newCampaign);
                AstraDbContext.SaveChanges();
                newCampaign.Id = campaign.Entity.Id;
            }
            return newCampaign;
        }

        public override Entities.Campaign Update(Entities.Campaign existingCampaign)
        {
            var campaign = AstraDbContext.Campaigns.FirstOrDefault(c => c.Id == existingCampaign.Id);
            if (campaign != null)
            {
                lock (this)
                {
                    campaign = existingCampaign;
                    AstraDbContext.Campaigns.Update(campaign);
                    AstraDbContext.SaveChanges();
                }
            }

            return existingCampaign;
        }
    }
}
