#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Pointer bizlere de�i�ken de�erlerimizin RAM bellekte hangi kod ile tutuldu�unu g�sterir
	//T�rk�e anlam� i�aret�i demektir
	//Bellekte tutulan kodlar Hexedecimal olarak tutulur (16'l�k say� birimi)
	
	int sayi1=10;
	int sayi2=20;
	double sayi3=10.25;
	char kelime='a';
	
	printf("%d\n",sayi1);
	printf("%d\n",sayi2);
	printf("%f\n",sayi3);
	printf("%c\n",kelime);
	
	printf("\n\n--- Bellek Adresleri --- \n\n");
	
	printf("%x\n",&sayi1);
	printf("%x\n",&sayi2);
	printf("%x\n",&sayi3);
	printf("%x\n",&kelime);
	
	
	//Program� birka� saat sonra tekrar �al��t�rd���m�zda bellek adres kodlar� de�i�ebilir
	//Her bilgisayarda bellek adres kodlar� de�i�kenlik g�sterebilir	
	
	
	return 0;
}
