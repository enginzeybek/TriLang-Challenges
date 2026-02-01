Console.WriteLine("Virgül ile ayırarak sayı dizisi giriniz.");
string? numbers = Console.ReadLine();
if (string.IsNullOrWhiteSpace(numbers))
{
    Console.WriteLine("Boş geçmeyiniz!");
    return;
}

string[] strArray = numbers.Split(",");
int[] intArray = Array.ConvertAll(strArray,int.Parse);

int result = 0;
bool found = false;

for (int i = 0; i < intArray.Length; i++)
{
    bool tekrar = false;

    for (int j = 0; j < intArray.Length; j++)
    {
        if (i != j && intArray[i] == intArray[j])
        {
            tekrar = true;
            break;
        }
    }

    if (!tekrar)
    {
        result = intArray[i];
        found = true;
        break;
    }
}

if (found)
{
    Console.WriteLine($"İlk tekrar etmeyen: {result}");
}
else
{
    Console.WriteLine("Tekrar etmeyen sayı yok");
}


