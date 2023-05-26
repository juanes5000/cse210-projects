class Word 
{
    private string singleWord;
    private bool hidden;
    public Word(String word)
    {
        singleWord = word;
        hidden = false;
    }

    public void Hide()
    {
        hidden = true;
    }
    public void Show()
    {
        hidden = false;
    }
    public bool IsHidden()
    {
        return hidden;
    }
    public string GetRenderedText()
    {
        if (hidden)
            return new string('_', singleWord.Length);
        else
            return singleWord;
    }
}