    using System.Collections.Generic;

public abstract class Command : ICommand
    {
        public IManager Manager { get; }
        public List<string> ArgsList { get; }

        protected Command()
        {

        }
        protected Command(List<string> args, IManager manager)
        {
            this.ArgsList = args;
            this.Manager = manager;
        }
        public abstract string Execute();
    }