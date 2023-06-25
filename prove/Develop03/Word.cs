
public class Word

{
    private string text;
    private bool hideWords;

    public Word(string _text)
    {
        text = _text;
    }

    public void Hide()
    {
        hideWords = true;
    }

    public void Show()
    {
        hideWords = false;
    }
    
    public bool GetHideWords()
    {
        return hideWords;
    }

    public string GetDisplayText()
    {
        return text;
    }
    
}