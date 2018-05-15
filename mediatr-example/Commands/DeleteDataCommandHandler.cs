using System.Threading.Tasks;
using MediatoRExample.Repositories;
using MediatR;

namespace MediatoRExample.Commands {
    public class DeleteDataCommandHandler : AsyncRequestHandler<DeleteDataCommand> {

        private DataRepository _dataRepository;

        public DeleteDataCommandHandler(DataRepository dataRepository) {

            _dataRepository = dataRepository;
        }
        protected override Task Handle(DeleteDataCommand request) {
            return Task.Run(() => {
                _dataRepository.Delete(request.Key);
            });
        }
    }
}