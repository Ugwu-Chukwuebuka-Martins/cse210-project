using System.IO;

public class Journal
{
    public List<Entry> _entries = [];
    Entry entry1 = new Entry();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
       foreach (Entry item in _entries)
       {
        entry1.Display(item);
       }
    }

    public void SaveToFile(string file)
    {
        using(StreamWriter output = new StreamWriter(file))
        {
            foreach (Entry item in _entries)
            {
            output.WriteLine($"{item._date},{item._promptText},{item._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            entry1._date = parts[0];
            entry1._promptText = parts[1];
            entry1._entryText = parts[2];
            AddEntry(entry1);
        }
    }
}