using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EventFlow.Queries;
using EventFlowExample.Queries;
using EventFlowExample.Repositories;

namespace EventFlowExample {
    public class GetDataQueryHandler : IQueryHandler<GetDataQuery, string> {
        private DataRepository _dataRepository;

        public GetDataQueryHandler(DataRepository dataRepository) {

            _dataRepository = dataRepository;
        }

        Task<string> IQueryHandler<GetDataQuery, string>.ExecuteQueryAsync(GetDataQuery query, CancellationToken cancellationToken) => Task.Run(() => {
            var result = _dataRepository.Get(query.Key);
            return result;
        });
    }
}