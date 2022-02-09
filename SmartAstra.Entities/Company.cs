using SmartAstra.Framework.Common;
using System.ComponentModel.DataAnnotations;

namespace SmartAstra.Entities
{
    public class Company : BaseEntityWithCreatedUpdatedDate
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public Status Status { get; set; }
        public int SubscriptionPlanId { get; set; }
    }
}
