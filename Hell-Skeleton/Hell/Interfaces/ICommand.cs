using System.Collections.Generic;

    public interface ICommand
    {
        IManager Manager { get; }
        List<string> ArgsList { get; }
        string Execute();
    }
