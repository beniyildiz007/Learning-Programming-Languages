
--��renciler tablosun ka� kay�t oldu�unu say ve g�r�nt�le:
--select count(*) as 'Toplam Kay�t' from [TBL-OGRENCILER]


--��renci tablosundaki �ehri Adana olan ka� tane ��renci oldu�unu getir:
--select count(*) as 'Toplam Ki�i' from [TBL-OGRENCILER] where OGR_SEHIR='Adana'



--Notlar tablosundaki ��rencilerin 1, 2 ve 3. s�nav notlar�n� topla:
--select sum(s�nav1),sum(s�nav2),sum(s�nav3) from TBL_NOTLAR


--Notlar tablosundaki ��rencilerin 3 s�nav notlar�n�n da ortalas�n� al:
--select avg(s�nav1),avg(s�nav2),avg(s�nav3) from TBL_NOTLAR



--Notlar tablosundaki ��rencilerin 3 s�nav notlar�n�n da en y�ksek de�erini al:
--select max(s�nav1),max(s�nav2),max(s�nav3) from TBL_NOTLAR



--Notlar tablosundaki ��rencilerin 3 s�nav notlar�n�n da en d���k de�erini al:
--select min(s�nav1),min(s�nav2),min(s�nav3) from TBL_NOTLAR