#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Mutlak deðer bulma
	double sayi,sonuc,logaritma;
	printf("Sayiyi girin: ");
	scanf("%lf",&sayi);
	sonuc=fabs(sayi);
	printf("Mutlak Deger Sonuc: %.lf",sonuc);
	
	
	//Logaritma
	logaritma=log(sayi);
	printf("\nSonuc Logaritma: %.7lf",logaritma);
	
	
	
	
	
	return 0;
}
