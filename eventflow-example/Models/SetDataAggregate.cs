using EventFlow.Aggregates;
using EventFlowExample.Models;

namespace EventFlowExample.Models
{
    public class SetDataAggregate : AggregateRoot<SetDataAggregate, SetDataId>
    {
        public SetDataAggregate(SetDataId id) : base(id)
        {
        }
    }
}