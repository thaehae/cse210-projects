
class PromptMenu
{
    List<string> prompts;

    public PromptMenu()
    {
        prompts = new List<string>
        {
            
            "What was a highlight of my day?",
            "How did I see the Lords hand in my life today?",
            "How did I serve someone today?",
            "What exercise did I do today?",
            "What new thing did I learn today?",
            "Who was special in my life today?",
            "What was your goal today and did you accomplish it?"

        };
    }

    public string GetRandomPrompt()
    {
        string randomPrompt = "";
        int randomIndex = new Random().Next(prompts.Count);

        randomPrompt = prompts[randomIndex];

        return randomPrompt;
    }
}