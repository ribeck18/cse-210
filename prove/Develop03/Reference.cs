class Reference
{
    //Attributes
    string _book;
    int _chapter;
    int _firstVerse;
    int _lastVerse;
    bool _isRange;

    //Constructors
    public Reference(string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = firstVerse;
        _isRange = false;
    }
    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
        _isRange = true;
    }

    //Methods
    public string GetReference()
    {
        if (_isRange == true)
        {
            string refString = $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
            return refString;
        }
        else
        {
            string refString = $"{_book} {_chapter}:{_firstVerse}";
            return refString;  
        }  
    }
    
}