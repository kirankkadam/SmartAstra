using SmartAstra.Framework.Common;

namespace SmartAstra.Framework.Entities.Interfaces
{
    public interface IMessage
    {
        string Body { get; set; }
        string From { get; set; }
        MessageType Type { get; set; }
        int SendMessage();
    }
}
