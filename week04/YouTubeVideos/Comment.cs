public class Comment
{
    string _username;
    string _text;
    public Comment(string username, string text)
    {
        SetUsername(username);
        SetText(text);
    }
    public string ShowComment()
    {
        return $"{_username}: {_text}";
    }
    private void SetUsername(string username)
    {
        _username = username;
    }
    private void SetText(string text)
    {
        _text = text;
    }
}