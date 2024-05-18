using System;

class Program
{
    static void Main(string[] args)
    {
        // exceed what is required.
        // by add the function that user can choose the reference to the script and write the script.
        Console.WriteLine("Enter the book:");
        string book = Console.ReadLine();

        Console.WriteLine("Enter the chapter:");
        int chapter = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the verse:");
        int verse = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the end verse (optional, press Enter to skip):");
        string endVerseInput = Console.ReadLine();
        int? endVerse = string.IsNullOrEmpty(endVerseInput) ? null : (int?)int.Parse(endVerseInput);

        Console.WriteLine("Enter the text of the scripture:");
        string scriptureText = Console.ReadLine();


        Reference reference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (!scripture.HideRandomWords(3))
            {
                Console.Clear();
                Console.WriteLine("All words are hidden!");
                break;
            }
        }
    }
}