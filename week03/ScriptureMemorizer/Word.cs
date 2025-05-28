public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        Console.Clear();
        foreach (char i in _text)
        {
            Console.Write("_");
        }
    }

    public void Show()
    {
        Console.Write(_text);
    }

    public bool IsHidden()
    {
        _isHidden = false;
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}
