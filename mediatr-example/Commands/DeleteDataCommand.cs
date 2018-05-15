using MediatR;

namespace MediatoRExample.Commands {
    public class DeleteDataCommand : IRequest {
        public string Key { get; set; }

        public DeleteDataCommand(string key) {
            Key = key;
        }
    }
}