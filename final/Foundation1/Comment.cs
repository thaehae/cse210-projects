using System;

public class Comment
{
    public string _namePerson;

    public List<Comment>_comment = new List<Comment>();

    public Comment()
    {
        _comment = new List<Comment>();
    }

    public void AddComment(Comment newComment)
    {
        _comment.Add(newComment);
    }
    

    public void DisplayComments()
    {

        Console.WriteLine($"Comment name: {_namePerson}");
        Console.WriteLine($"Comments: ");

        foreach (Comment comment in _comment)
        {
            comment.DisplayComments();
        }
    }

}