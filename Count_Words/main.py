words = input("Cümle giriniz: ")
if not words:
    print("Boş geçmeyiniz!!!")

unit = 0

wordList = words.split(" ")

for item in wordList:
   unit = unit + 1

print(f"Kelime sayısı: {unit}")