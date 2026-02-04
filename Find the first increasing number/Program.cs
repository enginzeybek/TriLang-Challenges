Console.WriteLine("Virgül ile ayırarak liste giriniz.");
string numbers = Console.ReadLine();
if (string.IsNullOrWhiteSpace(numbers))
{
    Console.WriteLine("Boş geçmeyiniz");
    return;
}
string[] strArray = numbers.Split(",");
int[] intArray = Array.ConvertAll(strArray,int.Parse);
for (int i = 1; i < intArray.Length; i++)
{
    if (intArray[i] > intArray[i - 1])
    {
        Console.WriteLine($"İlk artan sayı: {intArray[i]}");
        break;
    }
}

