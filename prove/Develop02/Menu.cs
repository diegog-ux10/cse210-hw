class Menu 
{
    public void DisplayIntro()
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

    public string readUserChoice()
    {
        string userChoice = "";
        Console.Write("What would you like to do?");
        userChoice = Console.ReadLine();
        while(userChoice != "5" & userChoice != "1" & userChoice != "2" & userChoice != "3" & userChoice != "4"){
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
        }
        return userChoice;
    }

    public string readUserContent()
    {
        Console.Write("Type your Answer: ");
        string content = Console.ReadLine();

        return content;
    }
}