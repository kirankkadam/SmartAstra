using System.Collections.Generic;

namespace SmartAstra.Data.Entity
{
    public class RecepientList:  BaseEntityWithCreatedUpdatedInfo
    {
        public string Name { get; set; }
        public List<int> RecepientIds { get; set; }
    }
}
