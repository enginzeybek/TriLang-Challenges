Console.WriteLine("Bir cümle giriniz");
string? sentence = Console.ReadLine();
if (string.IsNullOrEmpty(sentence))
{
    Console.WriteLine("Boş Geçmeyiniz!");
    return;
}

Sentence sentence1 = new Sentence();

sentence1.wordCount(sentence);


//---------------------------------------------------------------------------
/*string cumle = "Hello World";
string kelime = new string(cumle.Where(c => !char.IsPunctuation(c)).ToArray());
//Console.WriteLine(cumle.GetType());
Console.WriteLine("Kelime, " + kelime.GetType());*/
