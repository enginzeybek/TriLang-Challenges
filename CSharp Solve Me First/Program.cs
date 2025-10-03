while (true)
{
    Console.Write("Lütfen aralarına virgül gelecek şekilde iki sayı giriniz ve onların toplamlarını gör.");
    string? strNumbers = Console.ReadLine();

    if (string.IsNullOrEmpty(strNumbers))
    {
        Console.WriteLine("Lütfen boş geçmeyiniz!!");
    }

    string[] strNumbersArray = strNumbers.Split(",");

    int[] intNumbersArray = Array.ConvertAll(strNumbersArray, int.Parse);

    int result = 0;

    for (int i = 0; i < intNumbersArray.Length; i++)
    {   
        result += intNumbersArray[i];
    }

    Console.WriteLine($"Toplama işleminin sonucu: {result}");
}

