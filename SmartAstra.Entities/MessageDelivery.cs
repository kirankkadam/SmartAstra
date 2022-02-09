using SmartAstra.Framework.Common;

namespace SmartAstra.Entities
{
    public class MessageDelivery : BaseEntity
    {
        public int CampaignId { get; set; }
        public int UserId { get; set; }
        public DeliveryStatus Status { get; set; }
    }
}
