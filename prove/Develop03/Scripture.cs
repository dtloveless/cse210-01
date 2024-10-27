class Scripture
{
    // Attributes
    private Reference _reference;
    private List<Word> _words = new();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        List<string> textWords = new(text.Split(' '));
        foreach (string word in textWords)
        {
            Word newWord = new(word);
            _words.Add(newWord);
        }
    }

    // Methods
    public void Display()
    {
        _reference.Display();

        foreach (Word word in _words)
        {
            word.Display();
            Console.Write(' ');
        }
    }

    public void HideWords(int numToHide)
    {
        
        var visibleWords = _words.Where(word => ! word.GetIsHidden()).ToList();
        var random = new Random();

        for (int i = 0; i < numToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
}
