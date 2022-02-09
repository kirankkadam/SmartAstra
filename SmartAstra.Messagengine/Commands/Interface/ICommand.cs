using SmartAstra.Messagengine.Commands.Interface;

namespace SmartAstra.Commands.Interface
{
    public interface ICommand
    {
        void Execute(IMessageCommandData data);
        bool CanExecute(IMessageCommandData message);
        void Undo(IMessageCommandData message);
    }
}
