
### TOPLAMA İŞLEMİ (+) ###

a = 5
b = 3
print(a+b)
# Output => 8


s1 = 10.5
s2 = 20
print(s1+s2)
# Output => 30.5




### ÇIKARMA İŞLEMİ (-) ###

x = 100
y = 50
z = 20
diff = x - y - z
print(diff)
# Output => 30

a = 10.5
b = 4.2
c = 30
print(a-b-c)
# Output => -23.7




### ÇARPMA İŞLEMİ (*) ###

s1 = 10
s2 = 50
print(s1*s2)
# Output => 500

r = 4
cevre = 2 * 3.14 * r
print("Çevresi:", cevre)
# Output => 25.12




### BÖLME İŞLEMİ (/) ###

print(10/2)
# Output => 5.0

print(10.0/2.0)
# Output => 5.0

print(10/2.0)
# Output => 5.0

print(100/3)
# Output => 33.333333333333336




### TAMSAYI BÖLMESİ (//) ###

print(4//2)
# Output => 2

print(13//5)
# Output => 2

print(100//99)
# Output => 1

## Tamsayı Bölmesi yalnızca bölümün tamsayı kısmını yazdırır




### KALANI BULMA (%) ###

print(13%4) # 13'ün 4 ile bölümünden kalan 1'dir.
# Output => 1

print(14%2)
# Output => 0

print(330%117)
# Output => 96




### ÜS ALMA (**) ###

print(4**3) # 4 üssü 3
# Output => 64

print(2**12) # 2 üssü 12
# Output => 4096

print(3.14**5)
# Output => 305.2447761824001

print(2.0**3)
# Output => 8.0

print(64**0.5) # Karekök bulmak istediğimizde üssü 0.5 yapmamız gerekir!
# Output => 8.0





### İŞARET DEĞİŞTİRME ###

sonuc = 100
sonuc = -sonuc
print(sonuc)
# Output => -100

sonuc = 100
sonuc = -sonuc
sonuc = -sonuc
print(sonuc)
# Output => 100





### OPERATÖRLERDE İŞLEM ÖNCELİĞİ ###

print(12 - 5 + 3 * 2 / 0.5 + 25)
# Output => 44.0

print(12 - 5 + (3 * 2 / 0.5) + 25)
# Output => 44.0

# İşlemlerde öncelikle çarpma ve bölme uygulanır.
# Eğer işlemde parantez varsa her şeyden önce parantez içerisi hesaplanır.