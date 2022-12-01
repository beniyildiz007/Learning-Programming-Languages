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
