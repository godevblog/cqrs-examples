using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EventFlow.Aggregates.ExecutionResults;
using EventFlow.Commands;
using EventFlowExample.Models;
using EventFlowExample.Repositories;

namespace EventFlowExample.Commands {
    public class SetDataCommandHandler : CommandHandler<SetDataAggregate, SetDataId, IExecutionResult, SetDataCommand> {
        private DataRepository _dataRepository;

        public SetDataCommandHandler(DataRepository dataRepository) {

            _dataRepository = dataRepository;
        }

        public override Task<IExecutionResult> ExecuteCommandAsync(
            SetDataAggregate aggregate,
            SetDataCommand command,
            CancellationToken cancellationToken) {
            
            _dataRepository.Set(command.Key, command.Value);

            return Task.FromResult(ExecutionResult.Success());
        }
    }
}