#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	// Kullan�c�n�n girdi�i 2 say�y� topla ��kar �arp
	int s1,s2,toplam,fark,carpim;
	printf("Birinci sayiyi girin: ");
	scanf("%d",&s1); // Say�sal de�i�kenlerde %s yerine %d kullan�l�r ve degisken ad�ndan �nce & sembolu koyulur.
	
	
	printf("Ikinci sayiyi girin: ");
	scanf("%d",&s2);
	
	toplam=s1+s2;
	fark=s1-s2;
	carpim=s1*s2;
	
	printf("Toplam: %d\n",toplam);
	printf("Fark: %d\n",fark);
	printf("Carpim: %d",carpim);
	*/
	
	
	
	/*
	// Klavyeden bir kenar uzunlu�u girilen karenin alan ve �evresi
	int kenar,alan,cevre;
	
	printf("Karede Alan ve Cevre Hesabi\n\n");
	
	printf("Bir kenari girin: ");
	scanf("%d",&kenar);
	
	alan=kenar*kenar;
	cevre=kenar*4;
	
	printf("Karenin Alani: %d\n",alan);
	printf("Karenin Cevresi: %d",cevre);
	*/
	
	
	
	
	/*
	// Klavyeden 3 s�nav notu girilen ��rencinin ortalamas�
	int s1,s2,s3,ort;
	
	printf("Birinci Sinav: ");
	scanf("%d",&s1);
	
	printf("Ikinci Sinav: ");
	scanf("%d",&s2);
	
	printf("Ucuncu Sinav: ");
	scanf("%d",&s3);
	
	ort=(s1+s2+s3)/3;
	
	printf("Ortalamaniz: %d",ort);
	*/
	
	
	
	
	
	
	// Bir sinema salonundaki harcamaya g�re �cretlendirme �zetini ��karan program
	int su,kola,bilet,misir,toplam;
	
	printf("Misir Adedi: ");
	scanf("%d",&misir);
	
	printf("Kola Adedi: ");
	scanf("%d",&kola);
	
	printf("su Adedi: ");
	scanf("%d",&su);
	
	printf("Bilet Adedi: ");
	scanf("%d",&bilet);
	
	toplam=misir*2+kola*2+su*1+bilet*8; // Ekonominin hen�z cebimizi delip ge�medi�i zamanlar...
	
	printf("Toplam Borcunuz: %d",toplam);
	printf(" TL ...");
	
	
	
	
	
	
	
	
	return 0;
}
