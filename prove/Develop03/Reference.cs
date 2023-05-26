class Reference 
{
    private string book =  "John";
    private int chapter = 3;
    private int verse = 16;

    public string StringReference()
    {
        String referenceString = $"{book} {chapter}: {verse} ";
        return referenceString;
    }
}