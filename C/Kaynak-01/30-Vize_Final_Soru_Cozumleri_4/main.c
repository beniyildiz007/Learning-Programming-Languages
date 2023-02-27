#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//Bir havayolu þirketi yolcularý için bagaj sýnýrlamasý uygulamaktadýr.
	//Her yolcunun el için 8kg, normal için 15kg bagaj hakký bulunmaktadýr.
	//Eðer yolcular el hakkýný geçerse kg baþýna 4TL, normal haklarýný geçerse kg baþýna 5TL ödeme yapacaklardýr.
	//Buna göre klavyeden el ve normal bagaj kilolarý girilen yolcunun ödemesi gereken tutarý yazdýran programý yazýnýz.
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
	//Klavyeden birbirlerinden farklý 2 sayý girilmesini saðlayan ve bu iki sayý arasýndaki
	//(iki sayý dahil) tamsayýlarýn toplamýný hesaplayýp ekrana yazdýran programý yazýnýz.
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
	//Heybeliada'da bulunan yazýlým evi otelinde kýþ mevsiminden 320 kiþi kalmýþtýr.
	//Ýlkbaharda kýþ mevsiminin dörtte biri, yaz mevsiminde ilkbaharýn 8 katý ve sonbaharda yaz mevsiminin 10'da biri kadar kiþi kaldýðýna göre
	//bu otelde 1 yýl içerisinde toplam kaç kiþi kalmýþtýr?
	int yaz,kis,ilkbahar,sonbahar,toplam;
	kis=320;
	ilkbahar=kis/4;
	yaz=ilkbahar*8;
	sonbahar=yaz/10;
	
	toplam=kis+ilkbahar+sonbahar+yaz;
	printf("Toplam: %d",toplam); //Output = 1104
	*/
	
	
	
	
	
	
	
	//Klavyeden girilen 3 basamaklý bir sayýnýn basamak deðerleri toplamýný bulan programý yazýnýz.
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
