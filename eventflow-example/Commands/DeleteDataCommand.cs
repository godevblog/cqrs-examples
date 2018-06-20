
using EventFlow.Commands;
using EventFlowExample.Models;

namespace EventFlowExample.Commands {
    public class DeleteDataCommand : Command<DeleteDataAggregate, DeleteDataId> {
        public DeleteDataCommand(string key) : base(DeleteDataId.New)
        {
            Key = key;
        }

        public string Key { get; set; }
    }
}