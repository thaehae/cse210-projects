using System;

public class Video
{

    public string _title;

    public string _author;

    public int _lengthInSeconds;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public void StoreVideoComments()
    {

    }

    public void NumberVideoComments()
    {
        
    }

    public void DisplayDetails()
    {
         Console.WriteLine($"Title: {_title}; Author: {_author}; Length: {_lengthInSeconds} seconds ");        
    }
}