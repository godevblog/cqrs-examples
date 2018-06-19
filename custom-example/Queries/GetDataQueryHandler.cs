using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CustomExample.Queries;
using CustomExample.Repositories;

namespace CustomExample {
    public class GetDataQueryHandler : IQueryHandler<GetDataQuery, string> {
        private DataRepository _dataRepository;

        public GetDataQueryHandler(DataRepository dataRepository) {

            _dataRepository = dataRepository;
        }

        public Task<string> Execute(GetDataQuery query) {
            return Task.Run(() => {
                var result = _dataRepository.Get(query.Text);
                return result;
            });
        }
    }
}