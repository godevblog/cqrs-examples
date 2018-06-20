using EventFlow.Core;

namespace EventFlowExample.Models
{
    public class DeleteDataId : Identity<DeleteDataId>
    {
        public DeleteDataId(string value) : base(value)
        {
        }
    }
}