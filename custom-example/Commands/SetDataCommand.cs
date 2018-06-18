using CustomExample.Commands;

namespace CustomExample {
    public class SetDataCommand : ICommand {
        public SetDataCommand(string key, string value) {
            Key = key;
            Value = value;
        }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}