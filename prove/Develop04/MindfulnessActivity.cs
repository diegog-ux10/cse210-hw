using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"{this._name} Activity");
        Console.WriteLine(this._description);
        Console.WriteLine("Enter the duration of the activity in seconds:");
        this._duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Pause(3);
        ExecuteActivity();
        End();
    }

    protected abstract void ExecuteActivity();

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"You may begin in: {i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine(); // Asegura que la siguiente salida esté en una nueva línea
    }

    protected void End()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"Activity: {this._name}, Duration: {this._duration} seconds");
        Pause(3);
    }
}