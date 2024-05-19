public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void ExecuteActivity()
    {
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            Pause(6);
            Console.WriteLine("Breathe out...");
            Pause(6);
            elapsed += 6; // Each cycle is 6 seconds
        }
    }
}