using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatoRExample;
using MediatoRExample.Repositories;
using MediatR;

namespace MediatoRExample {
    public class SetDataCommandHandler : AsyncRequestHandler<SetDataCommand> {
        private DataRepository _dataRepository;

        public SetDataCommandHandler(DataRepository dataRepository) {

            _dataRepository = dataRepository;
        }

        protected override Task Handle(SetDataCommand request) {
            return Task.Run(() => {
                _dataRepository.Set(request.Key, request.Value);
            });
        }
    }
}