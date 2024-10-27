using System;

class Reference
{
    // Attributes
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Methods   
    public void Display()
    {
        if (_endVerse != _startVerse)
        {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}");
        }
    }
}


// public Reference(string reference)
    // {
    //     int bookIndex = reference.IndexOf(' ');
    //     int chapterIndex = reference.IndexOf(':');
    //     int verseIndex;
        
    //     if (reference.Contains('-'))
    //     {
    //         verseIndex = reference.IndexOf('-');
    //         _endVerse = int.Parse(reference.Substring(verseIndex + 1));
    //     }
    //     else
    //     {
    //         verseIndex = reference.Length;
    //         _endVerse = 0;
    //     }

    //     _book = reference.Substring(0, bookIndex);
    //     _chapter = int.Parse(reference.Substring(bookIndex + 1, chapterIndex - bookIndex - 1));
    //     _startVerse = int.Parse(reference.Substring(chapterIndex + 1, verseIndex - chapterIndex - 1));
    // }