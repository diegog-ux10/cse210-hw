public class Journal {
    private readonly List<Entry> _entries = [];

    public void AddEntry(string prompt, string content)
    {
        Entry newEntry = new(prompt, content);
        _entries.Add(newEntry);
    }

    public  void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        } 
    }

    
    public void SaveJournal()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
             foreach (Entry entry in _entries) {
                string date = entry._date.ToShortDateString();
                string prompt = entry._prompText; 
                string content = entry._entryText; 
                writer.WriteLine($"{date},{prompt},{content}");
            }
        }
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries) {
            entry.Display();
        }
        Console.WriteLine("Press Enter to continue");
        Console.ReadKey();
    }

    public void LoadJournal()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            string[] lines = File.ReadAllLines(filename);
            string dateFormat = "MM/dd/yyyy";
            IFormatProvider formatProvider = System.Globalization.CultureInfo.InvariantCulture;

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length >= 3)
                {
                    // Parse the date string
                    if (DateTime.TryParseExact(parts[0], dateFormat, formatProvider, System.Globalization.DateTimeStyles.None, out DateTime date))
                    {
                        string prompt = parts[1];
                        string content = parts[2];
                        Entry newEntry = new(prompt, content, date);
                        _entries.Add(newEntry);
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format in line: " + line);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid format in line: " + line);
                }
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while loading the journal: " + ex.Message);
        }
    }
}