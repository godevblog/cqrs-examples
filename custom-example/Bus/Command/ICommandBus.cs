using System.Threading.Tasks;
using CustomExample.Commands;

namespace CustomExample.Bus.Command
{
    public interface ICommandBus
    {
         Task SendCommand<TCommand>(TCommand command) where TCommand : ICommand;
    }
}