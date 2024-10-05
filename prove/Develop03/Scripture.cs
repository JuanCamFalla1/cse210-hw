public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int count = 0;

        while (count < numberToHide)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].isHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    }
     public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }        
        return referenceText + " " + string.Join(" ", displayWords);
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }
}