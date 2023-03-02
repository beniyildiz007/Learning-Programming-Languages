#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	printf("Katar Uzunlugu: %d",strlen("Merhaba Dunya")); //Output = 13 (Boþluklarý da sayar)
	
	
	
	char kelime[100];
	printf("\nKelimeyi girin: ");
	scanf("%s",kelime);
	printf("Girilen kelimenin uzunlugu: %d",strlen(kelime));
	//"Merhaba Dunya" cümlesini burada yazýnca sonuç 7 çýkar çünkü scanf boþluk ve sonrasýný almaz
	//Bunun için gets-puts kullanýlabilir.
	
	
	
	return 0;
}
