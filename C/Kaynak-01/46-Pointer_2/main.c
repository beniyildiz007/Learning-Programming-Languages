#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Bellek adres kodlar�n� de�i�kenlerde tutabiliriz
	int sayi=10;
	int *s=&sayi;
	
	//Say�y� ekrana yazd�rma
	printf("Deger: %d\n",sayi);
	
	//Adresi ekrana yazd�rma
	printf("Adres: %x\n",s);
	
	printf("\n--------------\n\n");
	
	char harf='a';
	char *h=&harf;
	
	//Harfi ekrana yazd�rma
	printf("Deger: %c\n",harf);
	
	//Adresi ekrana yazd�rma
	printf("Adres: %x\n",h);
	
	
	
	
	return 0;
}
