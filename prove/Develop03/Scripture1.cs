class Scripture1 
{
    private string _text = 
    "For God so loved the world, that he gave his only begotten Son,"+
    "that whosoever believeth in him should not perish, but have "+
    "everlasting life.";
    List<Word> _list = new List<Word>();

    public Scripture1(){

        string[] splittedStringArray = _text.Split(' ');
        _list = new List<Word>();

        foreach (string word in splittedStringArray)
        {
            _list.Add(new Word(word));
        }
    }

    public void HideWords(int count)
    {
        int hiddenCount = 0;
        Random random = new Random();

        while (hiddenCount < count)
        {
            int randomIndex = random.Next(_list.Count);
            Word word = _list[randomIndex];

            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
            }
        }
    }
    public string GetRenderedText()
    {        
        string renderedText = "";

        foreach (Word word in _list)
        {
            renderedText += word.GetRenderedText() + " ";
        }

    return renderedText.TrimEnd();
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _list)
        {
            if (!word.IsHidden())
                return false; 
        }
        return true;
    }
}