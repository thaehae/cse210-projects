public class ReflectionActivity : Activity

{
    private List<string> _reflectPrompts;
    private List<string> _questions;


    public ReflectionActivity(string name, string description, int duration, List reflectPrompts, List questions)
        : base(name, description, duration)

    {
        _reflectPrompts = reflectPrompts;
        _questions = questions;
    }
    public string GetRandomPrompt()
    {
        return _reflectPrompts;
    }

    public string GetRandomQuestion()
    {
        return _questions;
    }

    public void DisplayPrompt()
    {
        
    }

    public void DisplayQuestions()
    {
        
    }

    public void Run()
    {
        
    }

}