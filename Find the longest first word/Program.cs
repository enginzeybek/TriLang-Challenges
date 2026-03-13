using System.Text;
using System.Text.Unicode;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Lütfen boşluk ile ayrılmış bir cümle giriniz.");
string sentence = Console.ReadLine();
if (string.IsNullOrWhiteSpace(sentence))
{
    Console.WriteLine("Lütfen boş geçmeyiniz!");
}
string[] strSentence = sentence.Split(" ");
string result = strSentence[0];
for (int i = 0; i < strSentence.Length; i++)
{
    string maxWord = strSentence[i];

    if (maxWord.Length > result.Length)
    {
        result = maxWord;
        
    }
}

Console.WriteLine($"En uzun kelime: {result}");
