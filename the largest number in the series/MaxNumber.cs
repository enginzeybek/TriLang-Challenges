public class MaxNumber
{
    private readonly string _strNumbers;
    public MaxNumber(string strNumbers)
    {
        _strNumbers = strNumbers;
    }
    public void FindMax()
    {
        
        string[] strNumbersArray = _strNumbers.Split(",");
        int[] intNumberArray = Array.ConvertAll(strNumbersArray,Convert.ToInt32);

        int largeNumber = intNumberArray[0];

        for (int i = 1; i < intNumberArray.Length; i++)
        {
            
            if (intNumberArray[i] > largeNumber)
            {
                largeNumber = intNumberArray[i];
            }
        }
        Console.WriteLine($"Çıktı: {largeNumber}");
    }
}