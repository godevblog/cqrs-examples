using System.Threading.Tasks;
using CustomExample.Repositories;

namespace CustomExample.Commands {
    public class DeleteDataCommandHandler : ICommandHandler<DeleteDataCommand> {

        private DataRepository _dataRepository;

        public DeleteDataCommandHandler(DataRepository dataRepository) {

            _dataRepository = dataRepository;
        }

        public Task Handle(DeleteDataCommand command)
        {
            return Task.Run(() => {
                _dataRepository.Delete(command.Key);
            });
        }
    }
}