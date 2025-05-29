public class Comment
{
    public string _name;
    public string _text;

    public List<string> _commentsName = [];
    public List<string> _commentsText = [];

    public void AddComment(string name, string text)
    {
        _commentsName.Add(name);
        _commentsText.Add(text);
    }

    public void CommentView(int i)
    {
        Console.WriteLine($"COMMENT ==> Name: {_commentsName[i]} Text: {_commentsText[i]}");
    }
}