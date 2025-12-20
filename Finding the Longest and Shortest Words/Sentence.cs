

class Sentence
{
    private string _sentence;
    public Sentence(string sentence)
    {
        _sentence = sentence;
    }

    public void FindSentenceCount()
    {
        string[] strArray = _sentence.Split(" ");
        
        string Short = strArray[0];
        string Long = strArray[0];

        for (int i = 1; i < strArray.Length; i++)
        {
            if (Short.Length < strArray[i].Length)
            {
                Long = strArray[i];
            }
            else if (Long.Length > strArray[i].Length)
            {
                Short = strArray[i];
            }
        }
        Console.WriteLine($"En kısa kelime: {Short},En uzun kelime: {Long}");
    }
}