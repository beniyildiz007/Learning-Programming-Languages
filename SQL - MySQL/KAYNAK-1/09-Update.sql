
--��renciler tablosundaki b�t�n verilerin cinsiyetini K�z yap:
--update [TBL-OGRENCILER] set OGR_CINSIYET='K�z'


--��renci tablosundaki ID numaras� 4 ya da 5 olanlar�n cinsiyetlerini K�z yap:
--update [TBL-OGRENCILER] set OGR_CINSIYET='K�z' where OGR_ID=4 or OGR_ID=5


--��renciler tablsoundaki ad� Baran olan ��rencinin kul�b�n� Kitapl�k yap:
--update [TBL-OGRENCILER] set OGR_KULUP='Kitapl�k' where OGR_AD='Baran'