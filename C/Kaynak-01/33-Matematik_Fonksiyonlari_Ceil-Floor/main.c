#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//�ste ve alta yuvarlama i�lemi
	double sayi,sonuc1,sonuc2;
	
	printf("Degeri girin: ");
	scanf("%lf",&sayi);
	sonuc1=floor(sayi); //Say�y� alta yuvarlama (Floor=Zemin)
	sonuc2=ceil(sayi); //Say�y� �ste yuvarlama (Ceil=Tavan)
	printf("Alt Sonuc: %.f\n",sonuc1);
	printf("Ust Sonuc: %.f",sonuc2);	
	
	
	
	return 0;
}
