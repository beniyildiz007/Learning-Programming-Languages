#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	//gets-puts fonksiyonlar� yaz�lan metni b�t�n� ile al�r (bo�luklar dahil)
	char bilgi[10];
	printf("Bilgiyi girin: ");
	gets(bilgi);
	printf("\n\n");
	puts(bilgi);
	
	
	//�kinci y�ntem
	char bilgi2[10];
	printf("Bilgiyi girin: ");
	scanf("%[^\n]",bilgi2); //Bu sayede ayn� gets-puts y�ntemindeki gibi bo�luktan sonraki karakterler de al�n�r
	printf("%s",bilgi2);
	
	
	//�ki y�ntemde de de�i�kene 10 karakterlik k�s�tlama getirmeme ra�men girdi�im b�t�n veriyi ald� ve hepsini yazd�rd�
	//Nedenini ��zemedim, ara�t�rmalar�ma g�re edit�r kaynakl� oldu�u s�yleniyor.
	
	
	
	return 0;
}
