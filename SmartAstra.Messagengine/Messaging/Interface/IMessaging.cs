using SmartAstra.Framework.Common;
using SmartAstra.Framework.Entities.Interfaces;
using System.Threading.Tasks;

namespace SmartAstra.Messagengine.Interface
{
    public interface IMessaging
    {
        Task<int> SendMessage(IMessage message);

        IConfiguration GetConfiguration(MessageType messageType);
    }
}
