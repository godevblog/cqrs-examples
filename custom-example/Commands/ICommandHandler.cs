using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomExample.Commands
{
    public interface ICommandHandler
    {
         
    }

    public interface ICommandHandler<in TCommand>: ICommandHandler where TCommand: ICommand
    {
        Task Handle(TCommand command);
    }
}