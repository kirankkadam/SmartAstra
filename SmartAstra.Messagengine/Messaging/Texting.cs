using SmartAstra.Framework.Entities.Interfaces;
using System;
using System.Threading.Tasks;

namespace SmartAstra.Messagengine
{
    public class Texting : Messaging
    {
        public Texting(IMessage message) : base(message)
        {

        }
        public override Task<int> SendMessage(IMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
