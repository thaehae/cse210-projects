
public class Reference
{
    private string  book;
    private int     chapter;
    private int     startingVerse;
    private int     endingVerse;

    public Reference(string _book, int _chapter, int _startingVerse)
    {
        book =            _book;
        chapter =         _chapter;
        startingVerse =   _startingVerse;
    }

    public Reference(string _book, int _chapter, int _startingVerse, int _endingVerse)
    {
        book =            _book;
        chapter =         _chapter;
        startingVerse =   _startingVerse;
        endingVerse =     _endingVerse;
    }

    public string GetDisplayText()
    {
        string referenceDisplay = "";

        if (endingVerse != 0)
        {
            referenceDisplay = $"{book} {chapter}:{startingVerse}-{endingVerse}";
        }
        else
        {
            referenceDisplay = $"{book} {chapter}:{startingVerse}";
        }

        return referenceDisplay;
    }
}