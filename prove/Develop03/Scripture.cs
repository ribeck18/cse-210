using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;


class Scripture
{
    //Attributes
    Reference _reference;
    List<Word> _words;

    //Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = [];
        string[] stringWords = text.Split(" ");
        foreach (string word in stringWords)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    //Methods
    public string DislayReferance()
    {
        string reference = _reference.GetReference();
        return reference;
    }
    public void HideWords(int count)
    {
        //How many words total
        int wordCount = _words.Count();

        //loop based on count argument
        for (int i = 0; i < count;)
        {
            //random number in word count
            Random newRandom = new Random();
            int num = newRandom.Next(1, wordCount);

            //sets random word to hidden - If word is already hidden try again
            Word hiddenWord = _words[num];
            if (hiddenWord.GetHidden() == true)
                continue;
            hiddenWord.IsHidden(true);
            i++;
        }
    }
    public string DisplayVerse()
    {
        //get ref as string
        string reference = _reference.GetReference();

        //turn each word into a string
        List<string> words = [];
        foreach (Word word in _words)
        {
            string wordString = word.GetWord();
            words.Add(wordString);
        }
        string verse = string.Join(" ", words);

        return $"{reference} - {verse}";

    }
}