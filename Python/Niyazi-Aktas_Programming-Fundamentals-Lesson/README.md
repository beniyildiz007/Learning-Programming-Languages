# Niyazi Aktas hocama en derin sevgilerimle...
Marmara Üniversitesi Temel Programlama dersinde işlediğimiz Python ile ilgili 5 aylık konu anlatımı ve örnek uygulamaları burada görebilirsiniz.

>_Bilgi başarı getirmez, yalnızca başarı başarıyı getirir._

## İçindekiler (Contents)
1. [Hello World](#hello-world)
2. [Matematik Operatörleri](#matematik-operatorleri)
3. [String İfadeler](#string-ifadeler)
4. [Veri Tipi Dönüşümleri](#veri-tipi-donusumleri)
5. [Listeler](#listeler)

### Hello World! <a name="hello-world"></a>
```python
print("Hello World!")
# Output => Hello World



print("Hello World!")
print("Hello World!")
print("Hello World!")
# Output:
"""Hello World!
Hello World!
Hello World!"""




w = "python"
n = 10

print(w.capitalize()) # capitalize metodu cümlenin ilk harini büyük yapar
# Output => Python

print(n.bit_length()) # bit_length metodu İkili sistemde bir tamsayıyı temsil etmek için gereken bit sayısını verir
# Output => 4

help(w.capitalize) # Help metodu ise mevcut fonksiyon ile ilgili yardımcı bilgiler verir
# Output:
"""Help on built-in function capitalize:

capitalize() method of builtins.str instance
    Return a capitalized version of the string.

    More specifically, make the first character have upper case and the rest 
lower
    case."""
```

### Matematik Operatörleri <a name="matematik-operatorleri"></a>
```python

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
```

### String İfadeler <a name="string-ifadeler"></a>
```python
# Tek tırnak ('') ile string oluşturma:
print('Temel Programlama')
# Output => Temel Programlama


# Çift tırnak ("") ile string oluşturma:
print("İleri Programlama") # Sonuç değişmeyecektir
# Output => İleri Programlama


# 3 tek tırnak (''' ''') ile string oluşturma
print('''Python Öğreniyoruz...''') # 3 tane tek tırnak aynı zamanda çoklu satırlara izin verir
# Output => Python Öğreniyoruz...
print('''
Temel Programlama
İleri Seviye Programlama
Mobil Programlama
''')
"""Output↓↓
Temel Programlama
İleri Seviye Programlama
Mobil Programlama
"""
print("""
Temel Programlama
İleri Seviye Programlama
Mobil Programlama
""") # Sonuç yine aynı, değişmeyecektir.


# HANGİ TÜR TIRNAK İLE BAŞLANMIŞSA AYNISI İLE BİTİRİLMELİDİR!
# print("Temel Seviye Programlama')
# Output => SyntaxError! (Hata verir)


# Eğer string içerisinde tek tırnak kullanılacaksa cümle çift tırnak ile belirtilir:
print("Türkiye'nin başkenti Ankara'dır.")
# Output => Türkiye'nin başkenti Ankara'dır.




### STRING İFADELERİ DEĞİŞKEN İÇERİSİNE ATAMAK ###

adi = "Ali"
soyadi = "Can"
print(adi+soyadi)
# Output => Alican
print(adi+" "+soyadi)
# Output => Ali Can
print(adi,soyadi)
# Output => Ali Can




### STRING IFADELERİ INDEXLEME VE PARÇALAMA ###

"""Index numaraları her zaman 0'dan başlar.
Bir kelimenin 1. harfı 0. index numarasına aittir."""

hedef = "python öğrenmek"
print(hedef[0]) # hedef string ifadesinin 0. indeksindeki elemanı gösterir
# Output => p
print(hedef[2]) # hedef string ifadesinin 3. indeksindeki elemanı gösterir
# Output => t
print(hedef[-1]) # hedef string ifadesinin sondan 1. harfini yazdırır
# Output => k

baslik = "Python Programming Language"
print(baslik[4:10]) # 4. indeksten başla ve 10. indekse kadar al. (10. index dahil değildir)
# Output => on Pro

print(baslik[:10]) # Eğer başlangıç değeri belirtilmemişse en baştan itibaren alır.
# Output => Python Pro

print(baslik[4:]) # Eğer bitiş değeri belirtilmemişse en sona kadar alır.
# Output => on Programming Language

print(baslik[:]) # eğer iki değer de belirtilmemişse bütün string ifadesini alır.
# Output => Python Programming Language

print(baslik[:-1]) # Son karaktere kadar al. (Son karakter dahil değil!!!)
# Output => Python Programming Languag

print(baslik[::2]) # Baştan sona kadar 2'şer 2'şer atlayarak stringi al.
# Output => Pto rgamn agae

print(baslik[4:12:3]) # 4. indeksten 12. indekse kadar 3'er 3'er atlayarak al.
# Output => oPg

print(baslik[::-1]) # Baştan sona -1 atlayarak stringi al. (String ifadesinin ters çevirir)
# Output => egaugnaL gnimmargorP nohtyP




### STRING ÖZELLİKLERİ ###

# len() fonksiyonu (Uzunluk)
hangiDil = "Python Programlama Dili"
print(len(hangiDil)) # String ifadenin kaç karakterden oluştuğunu yazar.
# Output => 23


# Karakter Değiştirme Mümkün mü?
"""isim = "Ali KAYA"
isim[0] = "V"
print(isim)"""
# Bu ifadede HATA alınacaktır. Böyle bir özellik yalnızca listelerde mümkündür!
# Output => TypeError


# String ifadeleri değiştirmek
a = "Merve "
a = a + "Ece Ataman"
print(a) # String ifadeleri birleştirerek yine a değişkenine atadık
# Output => Merve Ece Ataman


# String ifadeler ile sayılar çarpılır mı?
parola = "Biz bu dili öğreneceğiz"
print(parola*3) # Böyle bir özellik mümkündür.
# Output => Biz bu dili öğreneceğizBiz bu dili öğreneceğizBiz bu dili öğreneceğiz

```

### Veri Tipi Dönüşümleri <a name="veri-tipi-donusumleri"></a>
```python

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
```

### Listeler <a name="listeler"></a>
```python

### Liste Oluşturma ###

liste = [3,4,5,6,"Elma",3.14,5.324]
print(liste) # Listenin içerisindeki farklı veri türlerini bulundurabiliriz.
# Output => [3, 4, 5, 6, 'Elma', 3.14, 5.324]


bos_liste=[]
print(bos_liste)
# Output => []

bos_liste=list() # Bu işlem de boş bir liste oluşturur.
print(bos_liste)
# Output => []


# len() fonksiyonu listeler üzerinde de kullanılabilir:
liste3 = [3,4,5,6,7,8,9,9,0,0,0,1]
print(len(liste3))
# Output => 12


# String bir ifade, list() fonksiyonu ile listeye dönüştürülebilir:
s = "merhaba"
lst = list(s)
print(lst)
# Output => ['m', 'e', 'r', 'h', 'a', 'b', 'a']



### Listeleri Indexleme ve Parçalama ###

liste = [3,4,5,6,7,8,9,10]
print(liste)
# Output => [3, 4, 5, 6, 7, 8, 9, 10]

# 0. eleman:
print(liste[0])
# Output => 3

# 4. eleman:
print(liste[4])
# Output => 7

# Sonuncu eleman:
print(liste[len(liste)-1]) # Listenin son elemanın index numarası, listenin eleman sayısından 1 eksiktir.
# Output => 10

# İlk eleman:
print(liste[-len(liste)]) # Listenin ilk elemanının index numarası, aynı zamanda listenin sondan başa doğru sayarsak -(listenin eleman uzunluğu) kadardır.
# Output => 3

# Baştan 4. indekse kadar (4. index dahil değil!)
print(liste[:4])
# Output => [3, 4, 5, 6]

# 1. indeksten 5. indekse kadar
print(liste[1:5])
# Output => [4, 5, 6, 7]

# 5. indeks ve sonrası:
print(liste[5:])
# Output => [8, 9, 10]

# Listenin elemanlarını 2'şer atlayarak yaz:
print(liste[::2])
# Output => [3, 5, 7, 9]

# Listeyi tersten yazdır:
print(liste[::-1])
# Output => [10, 9, 8, 7, 6, 5, 4, 3]



### Temel Liste Metodları ve İşlemleri ###

liste1 = [1,2,3,4,5]
liste2 = [1,2,3,4,5]
print(liste1+liste2)
# Output => [1, 2, 3, 4, 5, 1, 2, 3, 4, 5]


liste = [1,2,3,4]
liste = liste + ["Murat"]
print(liste)
# Output => [1, 2, 3, 4, 'Murat']


# Listeler direkt olarak değiştirilebilirler!
liste[0] = 10 # Listenin 0. indeksindeki elemanı 10 ile değiştirdik.
print(liste)
# Output => [10, 2, 3, 4, 'Murat']


# Listenin birden fazla elemanını aynı anda değiştirmek:
liste[:2] = [40,50] # Listenin baştan 2 elemanını 40 ve 50 ile değiştirdik.
print(liste)
# Output => [40, 50, 3, 4, 'Murat']


# Bir listeyi tamsayı ile çarpabiliriz:
liste = [1,2,3,4,5]
print(liste*3)
# Output => [1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5]
print(liste)
# Output => [1, 2, 3, 4, 5] ||| Listeyi değiştirmek için ↓
liste = liste*3
print(liste)
# Output => [1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5]


# append() Metodu
liste = [3,4,5,6]
liste.append(7) # liste isimli listeye 7 elemanını ekledik.
print(liste)
# Output => [3, 4, 5, 6, 7]
liste.append("Murat")
print(liste)
# Output => [3, 4, 5, 6, 7, 'Murat']


# pop() Metodu
liste = [1,2,3,4,5]
print(liste.pop()) # listenin içerisindeki son elemanı siler.
# Output => 5
print(liste)
# Output => [1, 2, 3, 4]
eleman = liste.pop(2)
print(eleman)
# Output => 3
print(liste)
# Output => [1, 2, 4]


# sort() Metodu
liste = [34,1,56,334,23,2,3,19]
liste.sort() # Listeyi küçükten büyüğe sıralar
print(liste)
# Output => [1, 2, 3, 19, 23, 34, 56, 334]

liste.sort(reverse=True) # Listeyi büyükten küçüğe sıralar
print(liste)
# Output => [334, 56, 34, 23, 19, 3, 2, 1]

liste = ["Elma","Armut","Muz","Kiraz"]
liste.sort() # Listeyi alfabetik olarak sıralar
print(liste)
# Output => ['Armut', 'Elma', 'Kiraz', 'Muz']

liste = ["Elma","Armut","Muz","Kiraz"]
liste.sort(reverse=True) # Listeyi alfabetik olarak sondan başa doğru sıralar
print(liste)
# Output => ['Armut', 'Elma', 'Kiraz', 'Muz']


## İç içe listeler ##

liste1 = [1,2,3]
liste2 = [4,5,6]
liste3 = [7,8,9]
yeniListe = [liste1,liste2,liste3]
print(yeniListe)
# Output => [[1, 2, 3], [4, 5, 6], [7, 8, 9]]

# Eğer bu listeden 4 sayısını yazdırmak istersek:
print(yeniListe[1][0]) # Listedeki 1. elemanın 0. elemanın ulaştık.
# Output => 4
```
