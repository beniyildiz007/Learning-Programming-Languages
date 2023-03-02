#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Bellek adres kodlarýný deðiþkenlerde tutabiliriz
	int sayi=10;
	int *s=&sayi;
	
	//Sayýyý ekrana yazdýrma
	printf("Deger: %d\n",sayi);
	
	//Adresi ekrana yazdýrma
	printf("Adres: %x\n",s);
	
	printf("\n--------------\n\n");
	
	char harf='a';
	char *h=&harf;
	
	//Harfi ekrana yazdýrma
	printf("Deger: %c\n",harf);
	
	//Adresi ekrana yazdýrma
	printf("Adres: %x\n",h);
	
	
	
	
	return 0;
}
