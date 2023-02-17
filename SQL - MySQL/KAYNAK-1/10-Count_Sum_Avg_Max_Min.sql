
--Öðrenciler tablosun kaç kayýt olduðunu say ve görüntüle:
--select count(*) as 'Toplam Kayýt' from [TBL-OGRENCILER]


--Öðrenci tablosundaki þehri Adana olan kaç tane öðrenci olduðunu getir:
--select count(*) as 'Toplam Kiþi' from [TBL-OGRENCILER] where OGR_SEHIR='Adana'



--Notlar tablosundaki öðrencilerin 1, 2 ve 3. sýnav notlarýný topla:
--select sum(sýnav1),sum(sýnav2),sum(sýnav3) from TBL_NOTLAR


--Notlar tablosundaki öðrencilerin 3 sýnav notlarýnýn da ortalasýný al:
--select avg(sýnav1),avg(sýnav2),avg(sýnav3) from TBL_NOTLAR



--Notlar tablosundaki öðrencilerin 3 sýnav notlarýnýn da en yüksek deðerini al:
--select max(sýnav1),max(sýnav2),max(sýnav3) from TBL_NOTLAR



--Notlar tablosundaki öðrencilerin 3 sýnav notlarýnýn da en düþük deðerini al:
--select min(sýnav1),min(sýnav2),min(sýnav3) from TBL_NOTLAR