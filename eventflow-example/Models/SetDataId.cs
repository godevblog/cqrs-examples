using EventFlow.Core;

namespace EventFlowExample.Models
{
    public class SetDataId : Identity<SetDataId>
    {
        public SetDataId(string value) : base(value)
        {
            
        }
    }
}