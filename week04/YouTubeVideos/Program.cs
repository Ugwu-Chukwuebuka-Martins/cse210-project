using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> _comments = [];
        Video video = new Video();
        video._title = "Allk";
        video._author = "Allk";
        video._length = 80;

        Comment comment = new Comment();
        comment._name = "Peter";
        comment._text = "Nice video";
        _comments.Add(comment);

        Comment comment1 = new Comment();
        comment1._name = "John";
        comment1._text = "The video is good";
        _comments.Add(comment1);

        Comment comment2 = new Comment();
        comment2._name = "James";
        comment2._text = "It is all about Allk";
        _comments.Add(comment2);

        Comment comment3 = new Comment();
        comment3._name = "Abram";
        comment3._text = "Good video";
        _comments.Add(comment3);

        Comment comment4 = new Comment();
        comment4._name = "Joseph";
        comment4._text = "Best video";
        _comments.Add(comment4);

        Console.WriteLine();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("                  VIDEO");
        video.Display();
        Console.WriteLine();
        Console.WriteLine("Names        :       Comments");
        foreach (Comment j in _comments)
        {
            Console.WriteLine($"{j._name}             {j._text}");
        }
        Console.WriteLine($"Number of Comments: {_comments.Count}");
        Console.WriteLine("---------------------------------------------");

        List<Comment> _comments2 = [];
        Video video1 = new Video();
        video1._title = "Spida man";
        video1._author = "Spid";
        video1._length = 90;

        comment._name = "John";
        comment._text = "This is a good video";
        _comments2.Add(comment);

        comment1._name = "John";
        comment1._text = "The video is good";
        _comments2.Add(comment1);

        comment2._name = "James";
        comment2._text = "It is all about spida";
        _comments2.Add(comment2);

        comment3._name = "Frank";
        comment3._text = "Good video";
        _comments2.Add(comment3);

        Console.WriteLine();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("                  VIDEO");
        video1.Display();
        Console.WriteLine();
        Console.WriteLine("Names        :       Comments");
        foreach (Comment j in _comments2)
        {
            Console.WriteLine($"{j._name}             {j._text}");
        }
        Console.WriteLine($"Number of Comments: {_comments2.Count}");
        Console.WriteLine("---------------------------------------------");

        List<Comment> _comments3 = [];
        Video video2 = new Video();
        video2._title = "Captain";
        video2._author = "Captain";
        video2._length = 100;

        comment._name = "Jacob";
        comment._text = "This is a good video";
        _comments3.Add(comment);

        comment1._name = "John";
        comment1._text = "The video is good";
        _comments3.Add(comment1);

        comment2._name = "James";
        comment2._text = "It is all about captain";
        _comments3.Add(comment2);

        Console.WriteLine();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("                  VIDEO");
        video2.Display();
        Console.WriteLine();
        Console.WriteLine("Names        :       Comments");
        foreach (Comment j in _comments3)
        {
            Console.WriteLine($"{j._name}             {j._text}");
        }
        Console.WriteLine($"Number of Comments: {_comments3.Count}");
        Console.WriteLine("---------------------------------------------");
    }
}