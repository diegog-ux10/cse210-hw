using System;

class Program
{
    static void Main(string[] args)
    { 
        Journal myJournal = new Journal();
        Menu menu = new Menu();
        PromptGenerator promptGenerator = new PromptGenerator();

        string userChoice = "";

        do
        {
        menu.DisplayIntro();
        userChoice = menu.readUserChoice();
            switch(userChoice) 
            {
                case "1":
                    string prompt = promptGenerator.chooseRandomPrompt();
                    Console.WriteLine(prompt);
                    string content = menu.readUserContent();
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
}