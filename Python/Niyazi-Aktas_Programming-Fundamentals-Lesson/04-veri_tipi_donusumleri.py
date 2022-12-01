
## Tamsayıyı Ondalıklı Sayıya Çevirme ##

a = 43
print(float(a))
# Output => 43.0
print(float(-1))
# Output => -1.0
print(float(9))
# Output => 9.0



## Ondalıklı Sayıyı Tamsayıya Çevirme ##

print(int(4.7))
# Output => 4
print(int(3.14))
# Output => 3
print(int(10.34566345343343))
# Output => 10

a = 4
b = 2
print(int(a/b))
# Output => 2



## Sayıları String İfadelere Çevirme ##

a = 32323242
b = str(a)
print(b) # Yine sayıyı yazdırır fakat rakam olarak değil, string ifade olarak!
# Output => 32323242
print(len(b))
# Output => 8

t = 3.14343
y = str(t)
print(y)
# Output => 3.14343
print(len(y)) # Sayı aslında 6 rakamlı fakat string ifade olunca nokta da dahil edilir!
# Output => 7



## String İfadeleri Tamsayıya Çevirme ##

a = "32324224232423"
b = int(a)
print(b) # Yine sayıyı yazar ve bu sefer rakam olarak yazar.
# Output => 32324224232423

"""
a = "asdasd3435343"
b = int(a)
print(b) # Hata verir çünkü sayıya çevirmeye çalıştığı ifadenin içerisinde harfler bulunuyor.
# Output => ValueError
"""



## String İfadeleri Ondalıklı Sayılara Çevirme ##

a = "3.14445454"
b = float(a)
print(b)

"""
a = "3.14.232423"
b = float(a) # Hata verir çünkü mevcut string ifadesi, float'a dönüştürülmeye uygun değildir.
print(b)
# Output => ValueError
"""