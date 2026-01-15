using System.IO;
using System.Transactions;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void DisplayEntries(List<Entry> entries)
    {
        foreach(Entry entry in entries)
        {
            entry.ShowEntry();
        }
    }
    public List<Entry> LoadEntries(string filename)
    {
        Journal journal = new Journal();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            Entry entry = new Entry();

            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._text = parts[2];
            journal._entries.Add(entry);
        }
        return journal._entries;
    }
    public void SaveEntries(string fileName, List<Entry> entries)
    {
        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._text}");
            }
        }
    }
}