using MediatR;

namespace MediatoRExample {
    public class SetDataCommand : IRequest {
        public SetDataCommand(string key, string value) {
            Key = key;
            Value = value;
        }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}