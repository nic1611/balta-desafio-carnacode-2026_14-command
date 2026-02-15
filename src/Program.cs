using Command.Commands;
using Command.Services;

public static class Program
{
    public static void Main(string[] args)
    {
        var editor = new TextEditor();
        var history = new EditorCommandHistory();

        history.Execute(new EditorCommand(editor, "Hello"));
        history.Execute(new EditorCommand(editor, " World"));

        Console.WriteLine(editor.GetContent()); // Hello World

        history.Undo();
        Console.WriteLine(editor.GetContent()); // Hello
    }
}