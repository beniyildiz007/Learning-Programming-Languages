
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