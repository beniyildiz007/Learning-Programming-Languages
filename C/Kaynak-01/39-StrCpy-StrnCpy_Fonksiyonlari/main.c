#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	char kaynak[30]="Merhaba Antalya";
	char kopya[30]="";
	
	strcpy(kopya,kaynak); //strcpy = String Copy
	printf("%s",kopya);
	printf("\n");
	*/
	
	
	
	char nereden[30]="Merhaba Ankara";
	char nereye[30]="";
	
	strncopy(nereye,nereden,9); //nereden değikenindeki cümlenin 9 karakterini nereye değişkenine aktar
	printf("%s",nereye);
	//Output = Merhaba A
	
	
	
	
	return 0;
}
