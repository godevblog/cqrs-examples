namespace CustomExample.Commands {
    public class DeleteDataCommand : ICommand {
        public string Key { get; set; }

        public DeleteDataCommand(string key) {
            Key = key;
        }
    }
}