using System;
using System.Threading.Tasks;
using Autofac;
using CustomExample.Bus.Command;
using CustomExample.Commands;

namespace CustomExample.Bus.Command {
    public class CommandBus : ICommandBus {
        private readonly ILifetimeScope _container;
        public CommandBus(ILifetimeScope container) {
            _container = container;
        }

        public Task SendCommand<TCommand>(TCommand command) where TCommand : ICommand {
            return Task.Run(() => {
                if (command == null) {
                    throw new ArgumentNullException(nameof(command));
                }

                var commandHandler = _container.ResolveOptional<ICommandHandler<TCommand>>();

                if (commandHandler == null) {
                    throw new Exception($"Not found handler for Command: '{command.GetType().FullName}'");
                }

                try {
                    commandHandler.Handle(command);
                } catch (Exception e) {
                    Console.WriteLine(e);
                }
            });
        }
    }
}