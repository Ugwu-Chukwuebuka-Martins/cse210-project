public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public void Display()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Video-Length: {_length}");
    }
}