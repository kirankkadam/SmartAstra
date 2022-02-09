using System;

namespace SmartAstra.Data.Entity
{
    public class BaseEntityWithCreatedUpdatedInfo: BaseEntity
    {
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }

    }
}
