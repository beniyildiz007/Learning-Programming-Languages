#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	printf("Katar Uzunlugu: %d",strlen("Merhaba Dunya")); //Output = 13 (Bo�luklar� da sayar)
	
	
	
	char kelime[100];
	printf("\nKelimeyi girin: ");
	scanf("%s",kelime);
	printf("Girilen kelimenin uzunlugu: %d",strlen(kelime));
	//"Merhaba Dunya" c�mlesini burada yaz�nca sonu� 7 ��kar ��nk� scanf bo�luk ve sonras�n� almaz
	//Bunun i�in gets-puts kullan�labilir.
	
	
	
	return 0;
}
