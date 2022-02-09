using SmartAstra.Framework.Common;

namespace SmartAstra.Entities
{
    public class Message : BaseEntityWithCreatedUpdatedDate
    {
        public string Name { get; set; }
        public MessageType Type { get; set; }
        public Status Status { get; set; }
        public int SendMessage()
        {
            throw new System.NotImplementedException();
        }
    }
}
