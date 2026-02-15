using Command.Interfaces;

namespace Command.Services;

public class EditorCommandHistory
{
    private readonly Stack<ICommand> _commands = new();

    public void Execute(ICommand command)
    {
        command.Execute();
        _commands.Push(command);
    }

    public void Undo()
    {
        if (_commands.Any())
        {
            _commands.Pop().Undo();
        }
    }
}