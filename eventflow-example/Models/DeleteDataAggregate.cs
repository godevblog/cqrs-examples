using EventFlow.Aggregates;

namespace EventFlowExample.Models
{
    public class DeleteDataAggregate : AggregateRoot<DeleteDataAggregate, DeleteDataId>
    {
        public DeleteDataAggregate(DeleteDataId id) : base(id)
        {
        }
    }
}