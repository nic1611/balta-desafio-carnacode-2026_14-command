namespace Command.Services;

public class TextEditor
{
    private string _content = "";

    public void Append(string text)
    {
        _content += text;
    }

    public void Delete(int length)
    {
        if (length > _content.Length)
        {
            length = _content.Length;
        }
        _content = _content.Substring(0, _content.Length - length);
    }

    public string GetContent()
    {
        return _content;
    }
}