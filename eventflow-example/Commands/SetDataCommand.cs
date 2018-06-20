using EventFlow.Commands;
using EventFlowExample.Models;

namespace EventFlowExample.Commands {
    public class SetDataCommand : Command<SetDataAggregate, SetDataId> {
        public SetDataCommand(
            string key,
            string value) : base(SetDataId.New) {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}