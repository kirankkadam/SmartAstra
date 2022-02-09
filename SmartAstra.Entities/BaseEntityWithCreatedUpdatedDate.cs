using System;

namespace SmartAstra.Entities
{
    public class BaseEntityWithCreatedUpdatedDate : BaseEntity
    {
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }

    }
}
