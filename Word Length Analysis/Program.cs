// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir cümle giriniz");
string? sentence = Console.ReadLine();

if (string.IsNullOrEmpty(sentence))
{
    Console.WriteLine("Lütfen boş geçmeyiniz.");
    return;
}

string[] sentenceArray = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);

string shortest = sentenceArray[0];
string longest = sentenceArray[0];

foreach (var word in sentenceArray)
{
    if (word.Length < shortest.Length)
        shortest = word;

    if (word.Length > longest.Length)
        longest = word;
}

Console.WriteLine($"En kısa kelime: {shortest} ({shortest.Length} harf)");
Console.WriteLine($"En uzun kelime: {longest} ({longest.Length} harf)");
