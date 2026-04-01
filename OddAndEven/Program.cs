Console.WriteLine("Lütfen virgül ile ayırarak sayılar giriniz");
string strNumbers = Console.ReadLine();
if (string.IsNullOrWhiteSpace(strNumbers))
{
    Console.WriteLine("Boş geçmeyiniz!");
    return;
}
string[] strArray = strNumbers.Split(",");
int[] intArray = Array.ConvertAll(strArray,int.Parse);
List<int> Odds = new List<int>();
List<int> Evens = new List<int>();
for (int i = 0; i < intArray.Length; i++)
{
    if (intArray[i] % 2 == 1)
    {
        Odds.Add(intArray[i]);
    }
    else if (intArray[i] % 2 == 0)
    {
        Evens.Add(intArray[i]);
    }
}

int OddSum = Odds.Sum();
double OddAvg = Odds.Average(); 

int EvenSum = Evens.Sum();
double EvenAvg = Evens.Average();

foreach (var item in Odds)
{
    Console.WriteLine($"Tek sayılar: {item}");
}
foreach (var item in Evens)
{
    Console.WriteLine($"Çift sayılar: {item}");
}

Console.WriteLine($"Tek sayıların toplamı: {OddSum}, ortalaması: {OddAvg}");
Console.WriteLine($"Çift sayıların toplamı: {EvenSum}, ortalaması: {EvenAvg}");
