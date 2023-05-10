using System;

class Program
{
    static void Main(string[] args)
    {
        Author author = new Author();
        Quote quote = new Quote();
        Words words = new Words(quote.getQouteText());

        string userPrompt;

        do
        {
            Console. Clear();
            Console.Write(author.getAuthorName());
            Console.WriteLine(quote.getQouteText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish");
            userPrompt = Console.ReadLine();
            if(!words.checkWords()){
                break;
            }

        } while(userPrompt != "quit");

        
    }
}