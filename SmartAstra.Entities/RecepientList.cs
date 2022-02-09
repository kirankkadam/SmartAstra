using System.Collections.Generic;

namespace SmartAstra.Entities
{
    public class RecepientList: BaseEntityWithCreatedUpdatedDate
    {
        public string Name { get; set; }
        public List<Recepient> Recepients { get; set; }
    }
}
