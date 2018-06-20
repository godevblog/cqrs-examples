using System.Threading;
using System.Threading.Tasks;
using EventFlow.Aggregates.ExecutionResults;
using EventFlow.Commands;
using EventFlowExample.Models;
using EventFlowExample.Repositories;

namespace EventFlowExample.Commands {
    public class DeleteDataCommandHandler : CommandHandler<DeleteDataAggregate, DeleteDataId, IExecutionResult, DeleteDataCommand> {

        private DataRepository _dataRepository;

        public DeleteDataCommandHandler(DataRepository dataRepository) {
            _dataRepository = dataRepository;
        }

        public override Task<IExecutionResult> ExecuteCommandAsync(
            DeleteDataAggregate aggregate,
            DeleteDataCommand command,
            CancellationToken cancellationToken) {
            _dataRepository.Delete(command.Key);
            return Task.FromResult(ExecutionResult.Success());
        }
    }
}