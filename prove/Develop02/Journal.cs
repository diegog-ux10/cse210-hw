public class Journal
{
    public List<Entry> Entries = new List<Entry>();

    public void AddEntry(string Prompt, string userAnswer) 
    {
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        Entry newEntry = new Entry(date, Prompt, userAnswer);
        Entries.Add(newEntry);
    }

    public void SaveJournal()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        if(!System.IO.File.Exists(filename)) 
        {
            System.IO.File.CreateText(filename);
        }

        using (StreamWriter writer = new StreamWriter(filename))
        {
             foreach (var Entry in Entries) {
                string date = Entry.date; 
                string prompt = Entry.prompt; 
                string content = Entry.content; 
                writer.WriteLine($"{date},{prompt},{content}");
            }
        }
    }

    public void DisplayJournal()
    {
        foreach (var Entry in Entries) {
            string date = Entry.date; 
            string prompt = Entry.prompt; 
            string content = Entry.content; 
            Console.WriteLine($"Date: {date} - Prompt: {prompt}");
            Console.WriteLine(content);
            Console.WriteLine();
        }
        Console.WriteLine("Press Enter to continue");
        Console.ReadKey();
    }

    public void LoadJournal()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string content = parts[2];
            Entry newEntry = new Entry(date, prompt, content);
            Entries.Add(newEntry);
        }
    }

    public void DeletedEntry()
    {

    }
}