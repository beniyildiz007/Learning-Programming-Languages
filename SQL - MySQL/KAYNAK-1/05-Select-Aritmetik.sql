--Öðrenciler tablosundan, þehri Adana olan ya da Satranç kulübünde olanlarý getir:
--Select * From [TBL-OGRENCILER] where OGR_SEHIR='Adana' or OGR_KULUP='Satranç'



--Decimal(x,y)
--x: Toplam basamak sayýsý
--y: Virgülden sonraki basamak sayýsý
--Ortalama en fazla 100,00 olabileceði için decimal(5,2) girilmelidir.



--SELECT * FROM TBL_NOTLAR
--Ortalamayý hesaplatmak için:
SELECT (SINAV1+SINAV2+SINAV3)/3 FROM TBL_NOTLAR