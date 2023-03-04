#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	FILE *belge;
	char karakter;
	belge=fopen("C:\\Users\\nihat\\OneDrive\\Belgeler\\GitHub\\Learning-Programming-Languages\\C\\56-Dosya_Islemler_3_Metin_Belgesi_Okuma\\bilgi.txt","r");
	
	//Metin belgesinin içerisindeki yazýmýz:
	//Merhaba, deprem bolgesinden herkese selamlar.
	karakter=getc(belge);
	
	printf("%c",karakter);
	//Bu þekilde yaparsak bize yalnýzca ilk karakteri, yani M harfini getirir
	
	do{
		karakter=getc(belge);
		
		printf("%c",karakter);
	}
	while(karakter!=EOF); //EOF = End Of File (Dosyanýn sonu)
	//Bu döngünün sonuucnda ekranda, belgenin içerisindeki bütün yazýlar görüntülenecektir
	
	fclose(belge);
	
	
	
	return 0;
}
