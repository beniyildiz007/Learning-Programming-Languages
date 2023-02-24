#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//Toplama buldurma
	int sayac=0;
	int i;
	for(i=1;i<=10;i++){
		sayac+=i;
	}
	printf("Sayac= %d",sayac);
	// Output = 55
	*/
	
	
	
	
	/*
	//Faktöriyel bulma
	int sayac=1;
	int i;
	for(i=1;i<=6;i++){
		sayac*=i;
	}
	printf("6 Sayisinin faktoriyeli= %d",sayac);
	//Output = 720
	*/
	
	
	
	
	
	//Kullanýcýnýn girdiði bir sayýnýn faktöriyelini bulma
	int i,sayi;
	int faktoriyel=1;
	
	printf("Faktoriyeli alinacak sayi: ");
	scanf("%d",&sayi);
	
	for(i=1;i<=sayi;i++){
		faktoriyel*=i;
	}
	printf("Girdiginiz sayinin faktoriyeli= %d",faktoriyel);
	
	
	
	
	
	
	return 0;
}
