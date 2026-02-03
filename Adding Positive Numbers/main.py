numbers = input("Virgül ile ayırarak sayı listesi giriniz.")
numbers = numbers.strip()
if not numbers:
    print("Boş geçmeyiniz!!!")
ListNumbers = numbers.split(",")
IntNumbers = list(map(int,ListNumbers))
sumNumbers = 0;
for item in IntNumbers:
    if item < 0:
        continue
    else:
        sumNumbers = item + sumNumbers
print(f"Pozitif sayıların toplamı: {sumNumbers}")