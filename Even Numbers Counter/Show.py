numbers = input("Sayıları virgülle ayırarak giriniz")
if not numbers:
    print("Lütfen sayı giriniz")
    exit()
Evens = 0
Odds = 0
strNumbers = numbers.split(",")
intNumbers = [int(x.strip()) for x in strNumbers]
#intNumbers = list(map(int,strNumbers))
for item in intNumbers:
    if item % 2 == 0:
        Evens += 1
    else:
        Odds += 1

print(f"Çift sayı adedi: {Evens},Tek sayı adedi: {Odds}")