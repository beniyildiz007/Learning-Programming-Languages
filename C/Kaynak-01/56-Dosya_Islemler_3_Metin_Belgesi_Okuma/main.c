#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	FILE *belge;
	char karakter;
	belge=fopen("C:\\Users\\nihat\\OneDrive\\Belgeler\\GitHub\\Learning-Programming-Languages\\C\\56-Dosya_Islemler_3_Metin_Belgesi_Okuma\\bilgi.txt","r");
	
	//Metin belgesinin i�erisindeki yaz�m�z:
	//Merhaba, deprem bolgesinden herkese selamlar.
	karakter=getc(belge);
	
	printf("%c",karakter);
	//Bu �ekilde yaparsak bize yaln�zca ilk karakteri, yani M harfini getirir
	
	do{
		karakter=getc(belge);
		
		printf("%c",karakter);
	}
	while(karakter!=EOF); //EOF = End Of File (Dosyan�n sonu)
	//Bu d�ng�n�n sonuucnda ekranda, belgenin i�erisindeki b�t�n yaz�lar g�r�nt�lenecektir
	
	fclose(belge);
	
	
	
	return 0;
}
