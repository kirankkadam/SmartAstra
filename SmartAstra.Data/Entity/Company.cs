using System.ComponentModel.DataAnnotations;

namespace SmartAstra.Data.Entity
{
    public class Company : BaseEntityWithCreatedUpdatedInfo
    {
        [Required(ErrorMessage = "Please enter a valid company name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a valid company address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a valid website address")]
        public string Website { get; set; }

        [Required(ErrorMessage = "Please enter a valid phone number")]
        [MaxLength(10)]
        [MinLength(8)]
        public string Phone { get; set; }
        public int Status { get; set; }
        public int SubscriptionPlanId { get; set; }
    }
}
