public class Word
{
    string _word;
    bool _hidden;
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public string GetDisplayText()
    {
        return _word;
    }
    public void Hide(string word)
    {
        _word = "";
        foreach(char letter in word)
        {
            _word += "_";
        }
        _hidden = true;
    }
    public bool IsHidden()
    {
        if(_hidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}