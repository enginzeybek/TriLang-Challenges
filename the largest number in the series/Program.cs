Console.WriteLine("Aralarında virgül olmak kaydıyla sayılar giriniz!");

string? strNumbers = Console.ReadLine();

if (string.IsNullOrEmpty(strNumbers))
{
    Console.WriteLine("Lütfen boş geçmeyiniz ve geçerli rakamlar giriniz!");
}

MaxNumber maxNumber = new MaxNumber(strNumbers);

maxNumber.FindMax();

