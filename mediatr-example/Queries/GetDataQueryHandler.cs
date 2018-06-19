using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatoRExample;
using MediatoRExample.Repositories;
using MediatR;

namespace MediatoRExample {
    public class GetDataQueryHandler : IRequestHandler<GetDataQuery, string> {
        private DataRepository _dataRepository;

        public GetDataQueryHandler(DataRepository dataRepository) {

            _dataRepository = dataRepository;
        }

        public Task<string> Handle(GetDataQuery request, CancellationToken cancellationToken) {

            return Task.Run(() => {
                var result = _dataRepository.Get(request.Text);
                return result;                                      
            });
        }
    }
}