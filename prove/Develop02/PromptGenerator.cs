public class PromptGenerator 
{
    private List<string> Prompts = new List<string>();

    public string chooseRandomPrompt()
    {
        Prompts.Add("What Was the Today's Best Thing?");
        Prompts.Add("Do you meet someone Today?");
        Prompts.Add("How was your Day?");
        Prompts.Add("Tell me one thing that you don't want to forget about today?");
        Random rnd = new Random();
        int num = rnd.Next(0, 3);
        return Prompts[num];
    }
}