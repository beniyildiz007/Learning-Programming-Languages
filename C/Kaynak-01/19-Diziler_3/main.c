#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//Klavyeden girilen þehirleri listeleyen dizi programý
	char sehir[3][15];
	int i;
	for(i=0;i<3;i++){
		printf("%d. Sehri Giriniz: ",i+1);
		scanf("%s",&sehir[i]);
	}
	printf("\n\n");
	
	for(i=0;i<3;i++){
		printf("%d. Sehir: %s\n",i+1,sehir[i]);
	}
	*/
	
	
	
	
	
	//Klavyeden dizi elemanlarý kadar sayý girilmesi ve listelenmesi
	int dizi[100];
	int i, sayi;
	
	printf("Eleman Sayisi: ");
	scanf("%d",&sayi);
	
	for(i=0;i<sayi;i++){
		printf("Dizinin %d. degerini girin: ",i+1);
		scanf("%d",&dizi[i]);
	}
	
	printf("\n\n");
	
	for(i=0;i<sayi;i++){
		printf("%d ",dizi[i]);
	}
	
	
	
	
	return 0;
}
