#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	char kitap[40];
	printf("Ad: ");
	scanf("%s",kitap);
	
	printf("%s",kitap); //Direkt olarak girilen kitab� yazar
	printf("\n");
	
	printf("%18s",kitap); //Kitap i�in 18 karakter ay�r�r, e�er kitap 18 karakterden k���kse sol taraf� bo�luklarla doldurur
	printf("\n");
	
	printf("%18.5s",kitap); //Yukar�dakinin ayn�s� fakat burada kitap i�in girdi�imiz de�erin yaln�zca 5 karakterini al�r
	printf("\n");
	
	printf("%-18s",kitap); //Y�zdelik de�er eksi(-) olarak yaz�l�rsa bo�lu�u soldan de�il sa�dan verir

	
	return 0;
}
