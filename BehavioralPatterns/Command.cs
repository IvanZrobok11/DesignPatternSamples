namespace BehavioralPatterns
{
    public interface ICommand
    {
        void Execute();
    }
    public class Command1 : ICommand
    {
        private readonly string _args;
        private readonly object _parametrs;

        public Command1(string args, object parametrs)
        {
            _args = args;
            _parametrs = parametrs;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class Command2 : ICommand
    {
        private readonly object _parametrs;

        public Command2(object parametrs)
        {
            _parametrs = parametrs;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class Invoker
    {
        private List<ICommand> Commands = new List<ICommand>();
        public void AddCommand(ICommand command)
        {
            Commands.Add(command);
        }
        public void InvokeCommands()
        {
            foreach (var c in Commands)
            {
                if (true)
                {
                    c.Execute();
                }
            }
        }
    }
}
