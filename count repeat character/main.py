text = input("Bir cümle giriniz")
array = []
printed = []

for item in text:
    if item == " ":
        continue
    array.append(item)

for c in array:
    if c in printed:
        continue

    count = 0

    for x in array:
        if x == c:
            count += 1
    
    printed.append(c)
    print(f"{c} : {count}")


