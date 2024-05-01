using System;

class Program
{
    static void Main()
    {
        // Call DisplayWelcome function
        DisplayWelcome();

        // Call PromptUserName function
        string userName = PromptUserName();

        // Call PromptUserNumber function
        int userNumber = PromptUserNumber();

        // Call SquareNumber function
        int squaredNumber = SquareNumber(userNumber);

        // Call DisplayResult function
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
