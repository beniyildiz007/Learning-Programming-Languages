#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Pointer bizlere deðiþken deðerlerimizin RAM bellekte hangi kod ile tutulduðunu gösterir
	//Türkçe anlamý iþaretçi demektir
	//Bellekte tutulan kodlar Hexedecimal olarak tutulur (16'lýk sayý birimi)
	
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
	
	
	//Programý birkaç saat sonra tekrar çalýþtýrdýðýmýzda bellek adres kodlarý deðiþebilir
	//Her bilgisayarda bellek adres kodlarý deðiþkenlik gösterebilir	
	
	
	return 0;
}
