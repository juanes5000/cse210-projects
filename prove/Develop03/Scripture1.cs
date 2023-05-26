class Scripture1 
{
    private string text = 
    "For God so loved the world, that he gave his only begotten Son,"+
    "that whosoever believeth in him should not perish, but have "+
    "everlasting life.";
    List<Word> list = new List<Word>();

    public Scripture1(){

        string[] splittedStringArray = text.Split(' ');
        list = new List<Word>();

        foreach (string word in splittedStringArray)
        {
            list.Add(new Word(word));
        }
    }

    public void HideWords(int count)
    {
        int hiddenCount = 0;
        Random random = new Random();

        while (hiddenCount < count)
        {
            int randomIndex = random.Next(list.Count);
            Word word = list[randomIndex];

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

        foreach (Word word in list)
        {
            renderedText += word.GetRenderedText() + " ";
        }

    return renderedText.TrimEnd();
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in list)
        {
            if (!word.IsHidden())
                return false; 
        }
        return true;
    }
}