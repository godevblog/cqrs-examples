using System.Collections.Generic;
using EventFlow.Queries;

namespace EventFlowExample.Queries {
    public class GetDataQuery : IQuery<string> {
        public GetDataQuery(string text)
        {
            Key = text;
        }

        public string Key { get; set; }
    }
}