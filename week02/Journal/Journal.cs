public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    private JournalStorage storage;

    public Journal(JournalStorage storage)
    {
        this.storage = storage;
    }

    public void AddEntry(string text)
    {
        entries.Add(new JournalEntry(text));
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.\n");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        storage.Save(filename, entries);
        Console.WriteLine("Journal saved successfully!\n");
    }

    public void LoadFromFile(string filename)
    {
        entries = storage.Load(filename);
        Console.WriteLine("Journal loaded successfully!\n");
    }
}
