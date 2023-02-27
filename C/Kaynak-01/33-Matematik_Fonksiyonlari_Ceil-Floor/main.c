#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Üste ve alta yuvarlama iþlemi
	double sayi,sonuc1,sonuc2;
	
	printf("Degeri girin: ");
	scanf("%lf",&sayi);
	sonuc1=floor(sayi); //Sayýyý alta yuvarlama (Floor=Zemin)
	sonuc2=ceil(sayi); //Sayýyý üste yuvarlama (Ceil=Tavan)
	printf("Alt Sonuc: %.f\n",sonuc1);
	printf("Ust Sonuc: %.f",sonuc2);	
	
	
	
	return 0;
}
