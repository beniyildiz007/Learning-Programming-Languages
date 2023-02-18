# 01- Create
```sql
Create Table TBL_DERSLER
(
DERS_ID tinyint,
DERS_AD varchar(20)
)
```

# 02- Alter Add
```sql
Alter Table TBL_DERSLER
Add KONTENJAN smallint
```

# 03- Alter Drop
```sql
Alter Table TBL_DERSLER
Drop Column KONTENJAN
```

# 04- Select
```sql
--Öğrenciler tablosundaki bütün verileri getir:
--Select * From [TBL-OGRENCILER]

--Öğrenciler tablosundaki sadece Ad ve Soyad sütunlarını getir:
--Select OGR_AD, OGR_SOYAD From [TBL-OGRENCILER]


--Öğrenciler tablosundaki adı Ali olanları getir
Select * From [TBL-OGRENCILER] where OGR_AD='Ali'
```

# 05- Select Aritmatik
```sql
--Öğrenciler tablosundan, şehri Adana olan ya da Satranç kulübünde olanları getir:
--Select * From [TBL-OGRENCILER] where OGR_SEHIR='Adana' or OGR_KULUP='Satranç'



--Decimal(x,y)
--x: Toplam basamak sayısı
--y: Virgülden sonraki basamak sayısı
--Ortalama en fazla 100,00 olabileceği için decimal(5,2) girilmelidir.



--SELECT * FROM TBL_NOTLAR
--Ortalamayı hesaplatmak için:
SELECT (SINAV1+SINAV2+SINAV3)/3 FROM TBL_NOTLAR
```

# 06- Insert
```sql
--Öğrenciler tablosuna ismi Berkan Nihat, soyadı Yıldız ve şehri Antalya olan veriyi ekledi
--insert into [TBL-OGRENCILER](OGR_AD,OGR_SOYAD,OGR_SEHIR) values ('Berkan Nihat','Yıldız','Antalya')


--Notlar tablosuna sayısal değerlerin girilmesi:
insert into TBL_NOTLAR (OGRENCI,DERS,SINAV1,SINAV3) values (6,2,88,67)

```

# 07- Delete
```sql
--Dersler tablosunun içerisindeki bütün verileri sil:
--delete from TBL_DERSLER



--Dersler tablosundaki Algoritma dersini sil:
delete from TBL_DERSLER where DERS_AD='Algoritma'

```

# 08- Truncate
```sql
--Dersler tablosundaki bütün verileri silmek için:
--truncate table TBL_DERSLER

--Delete ve Truncate arasındaki temel farklılık:
--Delete verileri silerken ID değerlerini sıfırlamaz ve kaldığı yerden devam eder
--Truncate verileri silerken bütün ID değerlerini de sıfırlar
--Truncate komutu, ilişkisel tablolarda sorunlara yol açabilir

```

# 09- Update
```sql
--Öğrenciler tablosundaki bütün verilerin cinsiyetini Kız yap:
--update [TBL-OGRENCILER] set OGR_CINSIYET='Kız'


--Öğrenci tablosundaki ID numarası 4 ya da 5 olanların cinsiyetlerini Kız yap:
--update [TBL-OGRENCILER] set OGR_CINSIYET='Kız' where OGR_ID=4 or OGR_ID=5


--Öğrenciler tablsoundaki adı Baran olan öğrencinin kulübünü Kitaplık yap:
--update [TBL-OGRENCILER] set OGR_KULUP='Kitaplık' where OGR_AD='Baran'

```

# 10- Count - Sum - Avg - Max - Min
```sql
--Öğrenciler tablosun kaç kayıt olduğunu say ve görüntüle:
--select count(*) as 'Toplam Kayıt' from [TBL-OGRENCILER]


--Öğrenci tablosundaki şehri Adana olan kaç tane öğrenci olduğunu getir:
--select count(*) as 'Toplam Kişi' from [TBL-OGRENCILER] where OGR_SEHIR='Adana'



--Notlar tablosundaki öğrencilerin 1, 2 ve 3. sınav notlarını topla:
--select sum(sınav1),sum(sınav2),sum(sınav3) from TBL_NOTLAR


--Notlar tablosundaki öğrencilerin 3 sınav notlarının da ortalasını al:
--select avg(sınav1),avg(sınav2),avg(sınav3) from TBL_NOTLAR



--Notlar tablosundaki öğrencilerin 3 sınav notlarının da en yüksek değerini al:
--select max(sınav1),max(sınav2),max(sınav3) from TBL_NOTLAR



--Notlar tablosundaki öğrencilerin 3 sınav notlarının da en düşük değerini al:
--select min(sınav1),min(sınav2),min(sınav3) from TBL_NOTLAR
```
