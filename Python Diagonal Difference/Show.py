print("Diagonal Difference")
print("---------------------")

n = int(input("Matris boyutunu giriniz: "))

matrix = []
for i in range(n):
    row = list(map(int, input(f"{i+1}. satırı girin: ").split()))
    matrix.append(row)

print("Matris:")
for row in matrix:
    print(row)

print("----------------------------------")
print("Çözüm 1")

left_top = matrix[0][0]
md = matrix[1][1]
bottom_right = matrix[2][2]

primary_sum = left_top + md + bottom_right

right_top = matrix[0][2]
#md
bottom_left = matrix[2][0]

secondary_sum = right_top + md + bottom_left

result = primary_sum - secondary_sum

mutlak = abs(result)

print(f"Mutlak değer {mutlak}")

print("----------------------------------")
print("Çözüm 2")

primary_sum = 0
secondary_sum = 0
n = len(matrix)

for i in range(n):
    primary_sum += matrix[i][i]            # Ana diagonal
    secondary_sum += matrix[i][n-1-i]      # Yan diagonal

result = abs(primary_sum - secondary_sum)

print(f"Mutlak değer: {result}")
