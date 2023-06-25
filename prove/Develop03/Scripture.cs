
public class Scripture
{
    private List<Word>  words;
    private Reference   reference;


    public Scripture(Reference _reference, string _text)
    {
        reference = _reference;
        words = new List<Word>();

        List<string> allTheWords = _text.Split(" ").ToList();
        foreach (string wordString in allTheWords)
        {
            Word newWord = new Word(wordString);
            words.Add(newWord);
        }
    }
    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach (Word word in words)
        {
            if (word.GetHideWords() == false)
            {
            scriptureText += word.GetDisplayText() + " ";
            }
            else
            {
            scriptureText += new string('_', word.GetDisplayText().Length) + " ";
            }
        }
        return ($"{reference.GetDisplayText()} {scriptureText}");
    }


    public void HideRandomWords(int _numberToHide)
    {
        
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

}