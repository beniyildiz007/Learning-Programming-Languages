--��renciler tablosundan, �ehri Adana olan ya da Satran� kul�b�nde olanlar� getir:
--Select * From [TBL-OGRENCILER] where OGR_SEHIR='Adana' or OGR_KULUP='Satran�'



--Decimal(x,y)
--x: Toplam basamak say�s�
--y: Virg�lden sonraki basamak say�s�
--Ortalama en fazla 100,00 olabilece�i i�in decimal(5,2) girilmelidir.



--SELECT * FROM TBL_NOTLAR
--Ortalamay� hesaplatmak i�in:
SELECT (SINAV1+SINAV2+SINAV3)/3 FROM TBL_NOTLAR