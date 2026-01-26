strNumbers = input("Virgülle ayırarak sayılar giriniz")
strList = strNumbers.split(",")
#intList = [int(sayi.strip()) for sayi in strList] #1.yol strip() boşlukları kaldırıyor.
intList = list(map(int,strList)) #2.yol
min = intList[0]
max = intList[0]
for x in intList:
    if x > max:
        max = x
    elif x < min:
        min = x

print(f"Min: {min},Max: {max}")

