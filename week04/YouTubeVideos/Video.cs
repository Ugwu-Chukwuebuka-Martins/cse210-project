public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<string> _titles = [];
    public List<string> _authors = [];
    public List<int> _lengths = [];

    Comment _comment = new Comment();

    public void AddVideoDetail(string title, string author, int length)
    {
        _titles.Add(title);
        _authors.Add(author);
        _lengths.Add(length);
    }

    public void VideoView(int i)
    {
        Console.WriteLine($"VIDEO   ==> Titles: {_titles[i]}, Author: {_authors[i]}, Video-Length:{_lengths[i]}");
    }
}