Console.WriteLine("Virgül ile ayırarak rakamlar giriniz.");
string? strNumbers = Console.ReadLine();

if (string.IsNullOrEmpty(strNumbers))
{
    Console.WriteLine("Boş geçmeyiniz!");
    return;
}

string[] strArrayNumbers = strNumbers.Split(",");
int[] intArraysNumbers = Array.ConvertAll(strArrayNumbers,int.Parse);

int notRepeat = intArraysNumbers[0];

List<int> repeats = new List<int>();

for (int i = 1; i < intArraysNumbers.Length; i++)
{
    if (intArraysNumbers[i] == notRepeat)
    {
        repeats.Add(notRepeat);
    }
    else
    {
        
        if (!repeats.Contains(notRepeat))
        {
            break; 
        }

        
        notRepeat = intArraysNumbers[i];
    }
    
}

Console.WriteLine("Tekrar etmeyen sayı: " + notRepeat);
