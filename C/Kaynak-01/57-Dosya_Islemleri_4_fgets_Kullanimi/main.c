#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	FILE *belge;
	char karakter[50];
	belge=fopen("C:\\Users\\nihat\\OneDrive\\Belgeler\\GitHub\\Learning-Programming-Languages\\C\\57-Dosya_Islemleri_4_fgets_Kullanimi\\bilgi.txt","r");
	//Belgemizde yazanlar:
	//6 Subat depremini unutmayacag�z, unutturmayacag�z.
	
	
	fgets(karakter,15,belge); //belgeden 15 karakteri al ve karakter de�i�kenine aktar
	puts(karakter); //karakter de�i�kenini ekranda g�r�nt�le
	//6 Subat deprem
	
	
	fclose(belge);
	
	
	
	return 0;
}
