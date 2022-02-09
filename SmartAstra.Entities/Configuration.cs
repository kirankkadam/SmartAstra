using SmartAstra.Framework.Common;

namespace SmartAstra.Entities
{
    public class Configuration: BaseEntity
    {
        public MessageType Type { get; set; }
        public string Config { get; set; }
    }
}
