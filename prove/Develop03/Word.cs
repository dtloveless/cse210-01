/* Written by Daniel Loveless */
using System.Text;

public class Word
{
    private string _text;
    private int _length;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _length = _text.Length;
        _isHidden = false;
    }

    public Word(string text, bool isHidden)
    {
        _text = text;
        _length = _text.Length;
        _isHidden = isHidden;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public int GetLength()
    {
        return _length;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Display()
    {
        if (_isHidden)
        {
            var displayText = new System.Text.StringBuilder();

            // Iterate through each character in the word
            foreach (char c in _text)
            {
                // Check if the character is a punctuation mark
                if (char.IsPunctuation(c))
                {
                    // Keep punctuation visible
                    displayText.Append(c);
                }
                else
                {
                    // Replace non-punctuation characters with underscores
                    displayText.Append('_');
                }
            }

            Console.Write(displayText.ToString());
        }
        else
        {
            Console.Write(_text);
        }
    }
}
