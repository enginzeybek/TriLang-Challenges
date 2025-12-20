
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Bir cümle giriniz.");
string? sentence = Console.ReadLine();
if (string.IsNullOrEmpty(sentence))
{
    Console.WriteLine("Lütfen bir cümle giriniz!");
    return;
}

Sentence sentence1 = new Sentence(sentence);
sentence1.FindSentenceCount();