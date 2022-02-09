using SmartAstra.Framework.Common;
using SmartAstra.Framework.Entities.Interfaces;
using SmartAstra.Messagengine.Configuration;
using SmartAstra.Messagengine.Interface;
using System.Threading.Tasks;

namespace SmartAstra.Messagengine
{
    public abstract class Messaging: IMessaging
    {
        public Messaging(IMessage message)
        {

        }

        public IConfiguration GetConfiguration(MessageType messageType)
        {
            return new BaseConfiguration();
        }
        public abstract Task<int> SendMessage(IMessage message);

    }
}
