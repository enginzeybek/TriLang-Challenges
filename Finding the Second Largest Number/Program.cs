Console.WriteLine("Virgül ile sayılar giriniz");
string? strNumbers = Console.ReadLine();
if (string.IsNullOrWhiteSpace(strNumbers))
{
    Console.WriteLine("Boş geçmeyiniz!");
}
string[] strArrayNumbers = strNumbers.Split(",");
int[] intArrayNumbers = Array.ConvertAll(strArrayNumbers,int.Parse);
int bignumber = intArrayNumbers[0];
int second = intArrayNumbers[0];
for (int i = 0; i < intArrayNumbers.Length; i++)
{
    if (intArrayNumbers[i] > bignumber)
    {
        second = bignumber;
        bignumber = intArrayNumbers[i];
    }
    else if (intArrayNumbers[i] > second && intArrayNumbers[i] != bignumber)
    {
        second = intArrayNumbers[i];
    }
}

Console.WriteLine("En büyük ikinci sayı: " + second);
