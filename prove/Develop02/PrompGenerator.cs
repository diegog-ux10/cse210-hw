public class PromptGenerator 
{
    private readonly List<string> prompts = new();

    public string ChooseRandomPrompt()
    {
        prompts.Add("What Was the Today's Best Thing?");
        prompts.Add("Do you meet someone Today?");
        prompts.Add("How was your Day?");
        prompts.Add("Tell me one thing that you don't want to forget about today?");
        Random rnd = new Random();
        int num = rnd.Next(0, 3);
        return prompts[num];
    }
}