public class JournalEntry
{
    public string Date { get; set; }
    public string Text { get; set; }

    public JournalEntry(string text)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        Text = text;
    }

    public override string ToString()
    {
        return $"{Date}\n{Text}\n";
    }
}

public abstract class JournalStorage
{
    public abstract void Save(string filename, List<JournalEntry> entries);
    public abstract List<JournalEntry> Load(string filename);
}