public class ListingActivity : Activity

{
    private int _letsCount;

    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int letsCount, List prompts)
        : base(name, description, duration)

    {
        
        _letsCount = letsCount;
        _prompts = prompts;

    }

    public void GetRandomPrompt()

    {
        return _prompts;
    }

    public List<String> GetListFromUser()

    {

    }

    public void Run()
    
    {
        
    }




}