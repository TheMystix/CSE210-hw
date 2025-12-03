using System.IO;

public class FileJournalStorage : JournalStorage
{
    public override void Save(string filename, List<JournalEntry> entries)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach (var entry in entries)
        {
            writer.WriteLine("-----");
            writer.WriteLine(entry.Date);
            writer.WriteLine(entry.Text);
        }
    }

    public override List<JournalEntry> Load(string filename)
    {
        List<JournalEntry> entries = new List<JournalEntry>();

        if (!File.Exists(filename))
            return entries;

        using (StreamReader reader = new StreamReader(filename))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line == "-----")
                {
                    string date = reader.ReadLine();
                    string text = reader.ReadLine();
                    entries.Add(new JournalEntry(text) { Date = date });
                }
            }
        }

        return entries;
    }
}
