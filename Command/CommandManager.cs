using System.Collections.Generic;

public class CommandManager
{
    #region singleton
    private static CommandManager _instance;

    public static CommandManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new CommandManager();
            return _instance;
        }
    }

    private CommandManager()
    {
    }
    #endregion

    private readonly Stack<Command> _commands = new Stack<Command>();

    public void Add(Command command)
    {
        _commands.Push(command);
    }

    public void CancelLast()
    {
        _commands.Pop();
    }

    public void ExecuteAll(Marine marine)
    {
        foreach (Command command in _commands)
            command.Execute(marine);
    }
}