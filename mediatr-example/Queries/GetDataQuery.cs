using System.Collections.Generic;
using MediatR;

namespace MediatoRExample {
    public class GetDataQuery : IRequest<string> {
        public GetDataQuery(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }
}