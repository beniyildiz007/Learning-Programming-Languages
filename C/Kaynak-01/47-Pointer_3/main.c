#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Adres kodlarýnda arttýrma ve azaltma gibi matematiksel iþlemler uygulanabilir
	
	char harf='k';
	char *pt=&harf;
	
	printf("Adres: %x\n",pt); //62fe17
	pt++;
	printf("Adres: %x\n",pt); //62fe18
	pt--;
	printf("Adres: %x\n",pt); //62fe17
	
	pt=pt+7;
	printf("Adres: %x\n",pt); //62fe1e
	//Hexedecimal kodlarda 9'dan sonra a-b-c-d-e-f gelir
	
	
	return 0;
}
