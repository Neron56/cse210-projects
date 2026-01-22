using System.Data;

public class Scripture
{
    Reference _reference;
    List<Word> _words;
    public Scripture(Reference reference, string verse)
    {
        SetReference(reference);
        _words = new List<Word>();
        string[] splitWords = verse.Split(" ");

        foreach(string word in splitWords)
        {
            Word text = new Word(word);
            _words.Add(text);
        }
    }
    private void SetReference(Reference reference)
    {
        _reference = reference;
    }
    public void HideRandomWords(int numberHiding)
    {
        Random number = new Random();
        int hiddenWords = 0;
        while(hiddenWords < numberHiding)
        {
            int wordIndex = number.Next(0,_words.Count());
            bool hidden = _words[wordIndex].IsHidden();
            if(hidden == false)
            {
                string word = _words[wordIndex].GetDisplayText();
                _words[wordIndex].Hide(word);
                hiddenWords += 1;
            }
        }
    }
    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string text = "";
        foreach(Word word in _words)
        {
            text += $" {word.GetDisplayText()}";
        }
        string scripture = $"{reference}{text}";
        return scripture;
    }
    public bool IsCompletelyHidden()
    {
        int hiddenCount = 0;
        int totalWordCount = 0;
        foreach(Word word in _words)
        {
            if(word.IsHidden() == true)
            {
                hiddenCount += 1;
                totalWordCount += 1;
            }
            else
            {
                totalWordCount +=1;
            }
        }
        if(totalWordCount == hiddenCount)
        {
            return true;
        }
        return false;
    }
}