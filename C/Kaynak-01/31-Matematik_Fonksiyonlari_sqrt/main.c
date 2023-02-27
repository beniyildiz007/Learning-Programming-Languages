#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Girilen sayýnýn karekökünü bulan program
	int sayi;
	double sonuc;
	printf("Sayiyi girin: ");
	scanf("%d",&sayi);
	sonuc=sqrt(sayi);
	printf("Sayinizin Karekoku: %.4f",sonuc); //%.4f komutu bize virgülden sonra 4 basamak yazdýrýr
	
		
	

	return 0;
}
