#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	// Ondal�kl� girilen say�lar� toplatma
	float s1,s2,toplam;
	
	printf("ilk sayiyi girin: ");
	scanf("%f",&s1);
	
	printf("ikinci sayiyi girin: ");
	scanf("%f",&s2);
	
	toplam=s1+s2;
	printf("Toplam Sonucu: %f",toplam);
	*/
	
	
	
	
	/*
	// Maa�a gelen %12'lik zamma g�re yeni maa�� hesaplamak
	printf("******* Zam Maas Hesabi *******");
	printf("\n\n");
	float maas,yenimaas;
	printf("Maasinizi girin: ");
	scanf("%f",&maas);
	yenimaas=maas+maas*12/100;
	printf("Yeni Maasiniz: %f",yenimaas);
	*/
	
	
	
	
	/*
	// �emberde alan ve �evre hesab� yapmak
	printf("Cemberde Alan ve Cevre Hesabi\n");
	printf("*********************************\n");
	
	float r,pi,alan,cevre;
	pi=3.14;
	printf("Yaricap Degeri: ");
	scanf("%f",&r);
	
	alan=pi*r,r;
	cevre=2*pi*r;
	
	printf("Alan: %f\n",alan);
	printf("Cevre: %f",cevre);
	*/
	
	
	
	
	
	
	// YGS-1 puan t�r� hesaplama
	float turkce,matematik,sosyal,fen,taban,toplampuan;
	
	taban=100.160;
	printf("Turkce Netiniz: ");
	scanf("%f",&turkce);
	
	printf("Matematik Netiniz: ");
	scanf("%f",&matematik);
	
	printf("Sosyal Bilgiler Netiniz: ");
	scanf("%f",&sosyal);
	
	printf("Fen Bilimleri Netiniz: ");
	scanf("%f",&fen);
	
	toplampuan=turkce*1.999+matematik*3.998+sosyal*1+fen*2.999+taban;
	printf("YGS-1 Puan Turunde Sonucunuz: %f",toplampuan);
	
	
	
	
	return 0;
}
