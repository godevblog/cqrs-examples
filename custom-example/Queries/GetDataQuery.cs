using System.Collections.Generic;
using CustomExample.Queries;

namespace CustomExample {
    public class GetDataQuery : IQuery<string> {
        public GetDataQuery(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }
}