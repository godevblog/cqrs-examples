using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CustomExample.Commands;
using CustomExample.Repositories;

namespace CustomExample {
    public class SetDataCommandHandler : ICommandHandler<SetDataCommand> {
        private DataRepository _dataRepository;

        public SetDataCommandHandler(DataRepository dataRepository) {

            _dataRepository = dataRepository;
        }

        public Task Handle(SetDataCommand command)
        {
           return Task.Run(() => {
                _dataRepository.Set(command.Key, command.Value);
            });
        }
    }
}