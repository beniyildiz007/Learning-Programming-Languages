#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	// Klavyeden girilen sayýnýn 3'e ve 5'e tam bölünüp bölünmediðini kontrol eden program
	int sayi;
	printf("Sayiyi giriniz: ");
	scanf("%d",&sayi);
	
	if(sayi%3==0 && sayi%5==0){
		printf("Girdiginiz sayi 3 ve 5'e tam bolunur.");
	}else{
		printf("Girdiginiz sayi 3 ve 5'e tam bolunmez.");
	}
	*/
	
	
	
	
	
	
	/*
	// Klavyeden girilen sayýnýn 3'e veya 5'e veya 7'ye tam bölünüp bölünmediðini kontrol eden program
	int sayi;
	printf("Sayiyi giriniz: ");
	scanf("%d",&sayi);
	
	if(sayi%3==0 || sayi%5==0 || sayi%7==0){
		printf("Girdiginiz sayi 3 veya 5 veya 7'ye tam bolunur.");
	}else{
		printf("Girdiginiz sayi 3 veya 5 veya 7'ye tam bolunmez.");
	}
	*/
	
	
	
	
	// Klavyeden girilen dereceye göre suyun durumunu yazdýran program
	printf("********* Suyun Durumu *********\n\n");
	
	int su;
	
	printf("Sicaklik degerini giriniz: ");
	scanf("%d",&su);
	
	if(su<=0){
		printf("Suyunuz buz halindedir.");
	}
	if(su>0 && su<100){
		printf("Suyunuz sivi halindedir.");
	}
	if(su>=100){
		printf("Suyunuz buhar halindedir");
	}
	
	
	
	
	
	
	return 0;
}
