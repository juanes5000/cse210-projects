class Word 
{
    private string _singleWord;
    private bool _hidden;
    public Word(String word)
    {
        _singleWord = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }
    public void Show()
    {
        _hidden = false;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public string GetRenderedText()
    {
        if (_hidden)
            return new string('_', _singleWord.Length);
        else
            return _singleWord;
    }
}