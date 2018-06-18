using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CustomExample.Queries;
using CustomExample.Repositories;
using MediatoRExample;

namespace CustomExample {
    public class GetDataQueryHandler : IQueryHandler<GetDataQuery, string> {
        private DataRepository _dataRepository;

        public GetDataQueryHandler(DataRepository dataRepository) {

            _dataRepository = dataRepository;
        }

        public Task<string> Handle(GetDataQuery request) {

            return Task.Run(() => {
                var result = _dataRepository.Get(request.Text);
                return result;
            });
        }
    }
}