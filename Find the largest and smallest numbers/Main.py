strNumbers = input("Virgülle ayrılmış olarak sayılar giriniz")

if strNumbers is None:
    print("Boş geçmeyiniz")
    exit()
    
strListNumbers = strNumbers.split(",")

intListNumbers = list(map(int, strListNumbers))

minN = intListNumbers[0]
maxN = intListNumbers[0]

for item in intListNumbers:
    if item > maxN:
        maxN = item
    elif item < minN:
        minN = item

print(f"En küçük= {minN},En büyük= {maxN}")
