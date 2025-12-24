public class Sentence
{
    public void wordCount(string sentence)
    {
        sentence = sentence.ToLower();
        sentence = new string(sentence.Where(c => !char.IsPunctuation(c)).ToArray());
        string[] sentenceStrArray = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        List<string> printedWords = new List<string>();
        
        for (int i = 0; i < sentenceStrArray.Length; i++)
        {
            string kelime = sentenceStrArray[i];

            if (printedWords.Contains(kelime))
            {
                continue;
            }

            int sayac = 0;

            for (int j = 0; j < sentenceStrArray.Length; j++)
            {
                if (sentenceStrArray[j] == kelime)
                {               
                    sayac++;
                }
            }
            printedWords.Add(kelime);
            Console.WriteLine($"{kelime} : {sayac}");
        }

    }
}