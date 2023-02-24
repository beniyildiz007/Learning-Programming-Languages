#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	

	printf("Ogrenci ortalama hesap bilgi sistemi\n\n");
	
	int s1,s2,ort;
	
	printf("1. Sinav sonucunu girin: ");
	scanf("%d",&s1);
	
	printf("2. Sinav sonucunu girin: ");
	scanf("%d",&s2);
	
	ort=(s1+s2)/2;
	
	printf("Ortalam puaniniz: %d\n\n",ort);
	
	if(ort>=50){
		printf("Tebrikler, geçtiniz!");
	}else{
		printf("Maalesef kaldin, seni tembel teneke...");
	}
	
	
	
	
	
	return 0;
}
