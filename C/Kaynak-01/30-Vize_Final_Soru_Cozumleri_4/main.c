#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//Bir havayolu �irketi yolcular� i�in bagaj s�n�rlamas� uygulamaktad�r.
	//Her yolcunun el i�in 8kg, normal i�in 15kg bagaj hakk� bulunmaktad�r.
	//E�er yolcular el hakk�n� ge�erse kg ba��na 4TL, normal haklar�n� ge�erse kg ba��na 5TL �deme yapacaklard�r.
	//Buna g�re klavyeden el ve normal bagaj kilolar� girilen yolcunun �demesi gereken tutar� yazd�ran program� yaz�n�z.
	int normal,el,normaltutar,eltutar,toplam;
	printf("El bagaj kg: ");
	scanf("%d",&el);
	
	printf("Normal bagaj kg: ");
	scanf("%d",&normal);
	
	if(normal<15){
		normaltutar=0;
	}
	else{
		normaltutar=(normal-15)*5;
	}
	
	if(el<8){
		eltutar=0;
	}
	else{
		eltutar=(el-8)*4;
	}
	toplam=normaltutar+eltutar;
	
	printf("Toplam Ekstra Odemeniz: %d TL, iyi yolculuklar...",toplam);
	*/
	
	
	
	
	
	
	/*
	//Klavyeden birbirlerinden farkl� 2 say� girilmesini sa�layan ve bu iki say� aras�ndaki
	//(iki say� dahil) tamsay�lar�n toplam�n� hesaplay�p ekrana yazd�ran program� yaz�n�z.
	int s1,s2,buyuk,kucuk,i,toplam=0;
	
	yeniden:
		printf("1. Sayi: ");
		scanf("%d",&s1);
		
		printf("2. Sayi: ");
		scanf("%d",&s2);
		
	if(s1==s2){
		goto yeniden;
	}
	else{
		if(s1>s2){
			buyuk=s1;
			kucuk=s2;
		}
		else{
			buyuk=s2;
			kucuk=s1;
		}
	}
	
	for(i=kucuk;i<=buyuk;i++){
		toplam+=i;
	}
	printf("Toplam: %d",toplam);
	*/
	
	
	
	
	
	
	
	/*
	//Heybeliada'da bulunan yaz�l�m evi otelinde k�� mevsiminden 320 ki�i kalm��t�r.
	//�lkbaharda k�� mevsiminin d�rtte biri, yaz mevsiminde ilkbahar�n 8 kat� ve sonbaharda yaz mevsiminin 10'da biri kadar ki�i kald���na g�re
	//bu otelde 1 y�l i�erisinde toplam ka� ki�i kalm��t�r?
	int yaz,kis,ilkbahar,sonbahar,toplam;
	kis=320;
	ilkbahar=kis/4;
	yaz=ilkbahar*8;
	sonbahar=yaz/10;
	
	toplam=kis+ilkbahar+sonbahar+yaz;
	printf("Toplam: %d",toplam); //Output = 1104
	*/
	
	
	
	
	
	
	
	//Klavyeden girilen 3 basamakl� bir say�n�n basamak de�erleri toplam�n� bulan program� yaz�n�z.
	int birler,onlar,yuzler,toplam,sayi;
	
	printf("Sayi: ");
	scanf("%d",&sayi);
	
	birler=sayi%10;
	onlar=(sayi/10)%10;
	yuzler=sayi/100;
	
	toplam=birler+onlar+yuzler;
	
	printf("Basamak Degerleri Toplami: %d",toplam);	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	return 0;
}
