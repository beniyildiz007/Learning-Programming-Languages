#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	//gets-puts fonksiyonlarý yazýlan metni bütünü ile alýr (boþluklar dahil)
	char bilgi[10];
	printf("Bilgiyi girin: ");
	gets(bilgi);
	printf("\n\n");
	puts(bilgi);
	
	
	//Ýkinci yöntem
	char bilgi2[10];
	printf("Bilgiyi girin: ");
	scanf("%[^\n]",bilgi2); //Bu sayede ayný gets-puts yöntemindeki gibi boþluktan sonraki karakterler de alýnýr
	printf("%s",bilgi2);
	
	
	//Ýki yöntemde de deðiþkene 10 karakterlik kýsýtlama getirmeme raðmen girdiðim bütün veriyi aldý ve hepsini yazdýrdý
	//Nedenini çözemedim, araþtýrmalarýma göre editör kaynaklý olduðu söyleniyor.
	
	
	
	return 0;
}
