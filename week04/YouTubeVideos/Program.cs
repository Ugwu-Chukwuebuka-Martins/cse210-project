using System;

class Program
{
    static void Main(string[] args)
    {
        Video _video = new Video();
        Comment _comMent = new Comment();

        _video._title = "Allk";
        _video._author = "Allk";
        _video._length = 80;

        _comMent._name = "Jacob";
        _comMent._text = "the video is nice";

        _video.AddVideoDetail(_video._title,_video._author,_video._length);
        _comMent.AddComment(_comMent._name,_comMent._text);


        _video._title = "Ayon Man";
        _video._author = "mavul";
        _video._length = 70;

        _comMent._name = "John";
        _comMent._text = "the video is interesting";

        _video.AddVideoDetail(_video._title,_video._author,_video._length);
        _comMent.AddComment(_comMent._name,_comMent._text);


        _video._title = "captain";
        _video._author = "cap";
        _video._length = 90;

        _comMent._name = "Joseph";
        _comMent._text = "the video is good";

        _video.AddVideoDetail(_video._title,_video._author,_video._length);
        _comMent.AddComment(_comMent._name,_comMent._text);


        _video._title = "captain";
        _video._author = "cap";
        _video._length = 60;

        _comMent._name = "Peter";
        _comMent._text = "the video is good";

        _video.AddVideoDetail(_video._title,_video._author,_video._length);
        _comMent.AddComment(_comMent._name,_comMent._text);
        for (int a=0; a<_video._titles.Count; a++)
        {
            Console.WriteLine("-----------------------------------------------------------");
            _video.VideoView(a);
            _comMent.CommentView(a);
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}