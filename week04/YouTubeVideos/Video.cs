using System.Net;
using System.Transactions;

public class Video
{
    string _title;
    string _author;
    int _length;
    List<Comment> _comments;
    public Video(string title, string author, int length)
    {
        SetTitle(title);
        SetAuthor(author);
        SetLength(length);
        _comments = [];
    }
    public void ShowVideoInformation()
    {
        int minutes = _length/60;
        int seconds = _length%60;
        Console.WriteLine($"'{_title}' by {_author}, Video Length({minutes}:{seconds}):");
        foreach(Comment comment in _comments)
        {    
            string text = comment.ShowComment();
            Console.WriteLine(text);
        }
        
    }
    private void SetTitle(string title)
    {
        _title = title;
    }
    private void SetAuthor(string author)
    {
        _author = author;
    }
    private void SetLength(int length)
    {
        _length = length;
    }
    public void AddComments(Comment comment)
    {
        _comments.Add(comment);
    }
}