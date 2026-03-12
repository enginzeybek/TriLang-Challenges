print("----------------------------------------------------")
numbers = input("Lütfen virgülle ayrılmış sayılar giriniz ")
numbersStrList = numbers.split(",")
numbersIntList = list(map(int,numbersStrList))

firstNumber = numbersIntList[0]

for item in numbersIntList:
    
    if firstNumber == item:
        pass

    elif firstNumber != item:
        firstNumber = item
        print(f"İlk farklı sayı: {firstNumber}")
        break