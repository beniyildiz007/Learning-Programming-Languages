
--Öðrenciler tablosundaki bütün verilerin cinsiyetini Kýz yap:
--update [TBL-OGRENCILER] set OGR_CINSIYET='Kýz'


--Öðrenci tablosundaki ID numarasý 4 ya da 5 olanlarýn cinsiyetlerini Kýz yap:
--update [TBL-OGRENCILER] set OGR_CINSIYET='Kýz' where OGR_ID=4 or OGR_ID=5


--Öðrenciler tablsoundaki adý Baran olan öðrencinin kulübünü Kitaplýk yap:
--update [TBL-OGRENCILER] set OGR_KULUP='Kitaplýk' where OGR_AD='Baran'