using Command.Interfaces;
using Command.Services;

namespace Command.Commands;

public class EditorCommand : ICommand
{
    private readonly TextEditor _editor;
    private readonly string _text;

    public EditorCommand(TextEditor editor, string text)
    {
        _editor = editor;
        _text = text;
    }

    public void Execute()
    {
        _editor.Append(_text);
    }

    public void Undo()
    {
        _editor.Delete(_text.Length);
    }
}