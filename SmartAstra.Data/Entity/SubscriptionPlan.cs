namespace SmartAstra.Data.Entity
{
    public class SubscriptionPlan : BaseEntity
    {
        public string Name { get; set; }
        public int UserLimit { get; set; }
        public int CampaignLimit { get; set; }
        public int RecepientPerCampaignLimit { get; set; }
    }
}
