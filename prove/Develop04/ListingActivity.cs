public class ListingActivity : MindfulnessActivity
{
    private static readonly string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void ExecuteActivity()
    {
        Random rand = new Random();
        Console.WriteLine(Prompts[rand.Next(Prompts.Length)]);
        Pause(3);
        Console.WriteLine("Start listing items:");
        Pause(3);
        int elapsed = 0;
        int count = 0;
        while (elapsed < _duration)
        {
            Console.ReadLine();
            count++;
            elapsed += 3;
        }
        Console.WriteLine($"You listed {count} items.");
    }
}