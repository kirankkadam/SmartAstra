using SmartAstra.Framework.Entities.Interfaces;

namespace SmartAstra.Messagengine.Commands.Interface
{
    public interface IMessageCommandData
    {
        IMessage Message { get; set; }
    }
}
