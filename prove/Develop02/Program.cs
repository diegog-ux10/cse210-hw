using System;

class Program
{
    static void Main()
    {
       Journal myJournal = new();
       PromptGenerator promptGenerator = new();

       string userChoice = "";

       do{
        DisplayIntro();
        userChoice = ReadUserChoice();
        switch(userChoice) 
            {
                case "1":
                    string prompt = promptGenerator.ChooseRandomPrompt();
                    Console.WriteLine(prompt);
                    string content = ReadUserContent();
                    myJournal.AddEntry(prompt, content);
                break;
                case "2":
                    myJournal.DisplayJournal();
                break;
                case "3":
                    myJournal.LoadJournal();
                break;
                case "4":
                    myJournal.SaveJournal();
                break;
            }


       } while(userChoice != "5");
    }

    static void DisplayIntro()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }

    static string ReadUserChoice()
    {
        string userChoice = "";
        Console.Write("What would you like to do?");
        userChoice = Console.ReadLine();
        while(userChoice != "5" & userChoice != "1" && userChoice != "2" & userChoice != "3" & userChoice != "4"){
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
        }
        return userChoice;
    }

    static string ReadUserContent()
    {
        Console.Write("Type your Answer: ");
        string content = Console.ReadLine();

        return content;
    }

    
}