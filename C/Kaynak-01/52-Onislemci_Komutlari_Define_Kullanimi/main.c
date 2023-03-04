#include <stdio.h>
#include <stdlib.h>

#define tPuan 2.19
#define mPuan 3.47

/* run this program using the console pauser or add your own getch, system("pause") or input loop */



int main() {
	
	
	int turkce,matematik;
	printf("Turkce netinizi giriniz: ");
	scanf("%d",&turkce);
	printf("Matematik netinizi giriniz: ");
	scanf("%d",&matematik);

	
	float sozelPuan,sayisalPuan;
	sozelPuan=turkce*tPuan+matematik*mPuan+50.25;
	sayisalPuan=turkce*tPuan+matematik*mPuan+51.45;
	
	printf("Toplam Sozel Puaniniz: %.2f\n",sozelPuan);
	printf("Toplam Sayisal Puaniniz: %.2f",sayisalPuan);
		
	
	
	return 0;
}
