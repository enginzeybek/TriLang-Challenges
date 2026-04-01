numbers = input("Lütfen virgül ile ayırarak sayılar giriniz")
strList = numbers.split(",")
intList = list(map(int,strList))

longest = []
count = []
numeral = intList[0]

for item in intList:
    if item >= numeral:
        longest.append(item)
    else:
        count.append(len(longest))
        #longest.clear()
        longest = [item]
    numeral = item

count.append(len(longest))

maxCount = 0
for x in count:
    if x > maxCount:
        maxCount = x

print(f"En uzun artan seri uzunluğu: {maxCount}")        