using SmartAstra.Commands.Interface;
using SmartAstra.Messagengine.Commands.Interface;
using SmartAstra.Messagengine.Interface;
using System;

namespace SmartAstra.Commands
{
    public class SendMessageCommand : ICommand
    {
        public bool CanExecute(IMessageCommandData commandData)
        {
            var message = commandData.Message;
            var result = message.SendMessage();            
            return true;
        }

        public void Execute(IMessageCommandData message)
        {
            throw new NotImplementedException();
        }

        public void Undo(IMessageCommandData message)
        {
            throw new NotImplementedException();
        }
    }
}
