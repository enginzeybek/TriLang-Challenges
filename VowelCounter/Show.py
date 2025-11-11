sentence = input("Bir cümle giriniz")
if not sentence.strip():  # Boş veya sadece boşluksa
    print("Lütfen geçerli bir cümle girin!")
else:
    print(f"Cümleniz: {sentence}")

vowels = ["a","e","ı","i","o","ö","u","ü"]
countVowels = 0

for item in sentence:
    item = item.lower()
    if item in vowels:
        countVowels += 1

print(f"Girdiğiniz cümledeki sesli harf sayısı {countVowels}")