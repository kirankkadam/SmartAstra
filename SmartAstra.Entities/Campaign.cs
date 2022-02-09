using SmartAstra.Framework.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAstra.Entities
{
    public class Campaign : BaseEntityWithCreatedUpdatedDate
    {
        [Required(ErrorMessage = "Please provide a valid Campaign name")]
        public string Name { get; set; }
        public Status Status { get; set; }
        public int RecepientListId { get; set; }
        public int MessageId { get; set; }

        [ForeignKey("Campaign_Schedule_Id")]
        public int ScheduleId { get; set; }
    }
}
