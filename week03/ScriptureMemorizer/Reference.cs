using System.Security.Cryptography;

public class Reference
{
    string _book;
    int _chapter;
    int _verse;
    int _endVerse;

    public Reference()
    {
        SetBook("1 Nephi");
        SetChapter(1);
        SetVerse(12);
        SetEndVerse(0);
    }
    public Reference(string book, int chapter, int verse)
    {
        SetBook(book);
        SetChapter(chapter);
        SetVerse(verse);
        SetEndVerse(0);
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        
        SetBook(book);
        SetChapter(chapter);
        SetVerse(verse);
        SetEndVerse(endVerse);
    }
    public string GetDisplayText()
    {
        if(_endVerse == 0)
        {
            string reference = $"{_book} {_chapter}: {_verse}";
            return reference;
        }
        else
        {
            string reference = $"{_book} {_chapter}: {_verse}-{_endVerse}";
            return reference;
        }
    }

    private void SetBook(string book)
    {
        _book = book;
    }
    private void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    private void SetVerse(int verse)
    {
        _verse = verse;
    }
    private void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }
}