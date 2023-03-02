#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	char kitap[40];
	printf("Ad: ");
	scanf("%s",kitap);
	
	printf("%s",kitap); //Direkt olarak girilen kitabý yazar
	printf("\n");
	
	printf("%18s",kitap); //Kitap için 18 karakter ayýrýr, eðer kitap 18 karakterden küçükse sol tarafý boþluklarla doldurur
	printf("\n");
	
	printf("%18.5s",kitap); //Yukarýdakinin aynýsý fakat burada kitap için girdiðimiz deðerin yalnýzca 5 karakterini alýr
	printf("\n");
	
	printf("%-18s",kitap); //Yüzdelik deðer eksi(-) olarak yazýlýrsa boþluðu soldan deðil saðdan verir

	
	return 0;
}
