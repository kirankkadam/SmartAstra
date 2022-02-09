using System;

namespace SmartAstra.Framework.Entities.Interfaces
{
    public interface IEntityCreatedUpdatedInfo : IEntity
    {
        DateTime CreatedOn { get; set; }
        int CreatedBy { get; set; }
        DateTime UpdatedOn { get; set; }
        int UpdatedBy { get; set; }

    }
}
