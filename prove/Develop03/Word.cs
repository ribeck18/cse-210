using System.Dynamic;

class Word
{
  //Attributes
    string _word;
    bool _isHidden;

  //Constructors
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    //Methods  
    public string GetWord()
    {
        if (_isHidden == true)
        {
            string hidden = new string('_', _word.Length);
            return hidden;
        }

        return _word;
    }
    public bool IsHidden(bool isHidden)
    {
        _isHidden = isHidden;
        return _isHidden;
    }

    public bool GetHidden()
    {
        return _isHidden;
    }
}