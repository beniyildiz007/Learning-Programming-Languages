#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	/*
	//Üç basamaklý ve rakamlarý birbirinden farklý kaç tane sayý olduðunu bulan program
	int sayac=0,i,a,b,c,sayi;
	
	for(i=100;i<=999;i++){
		
		a=i/100;
		b=(i/10)%10;
		c=i%10;
		
		if(a!=b && a!=c && b!=c){
			
			sayac++;	
		}
	}
	printf("%d",sayac); //Output = 648
	*/
	
	
	
	
	/*
	//Klavyeden girilen sayýnýn tam bölenlerini bulan program
	int sayi,i;
	printf("Sayiyi giriniz: ");
	scanf("%d",&sayi);
	
	for(i=1;i<=sayi;i++){
		
		if(sayi%i==0){
			
			printf("%d\n",i);
		}
	}
	*/
	
	
	
	
	
	
	
	//Klavyeden girilen sayýnýn küpünü alan program
	int sayi,sonuc;
	printf("sayiyi giriniz: ");
	scanf("%d",&sayi);
	
	sonuc=sayi*sayi*sayi;
	printf("%d",sonuc);	
	
	
	
	
	
	
	
	return 0;
}
