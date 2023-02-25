#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	/*
	//1-50 arasýnda 5'e tam bölünen sayýlarý yazdýran program
	int i;
	for(i=1;i<=50;i++){
		if(i%5==0){
			printf("%d\n",i);
		}
	}
	*/
	
	
	
	
	//3 basamaklý bir sayýyý basamak deðerlerine ayýran program
	int sayi;
	sayi=574;
	int birler,onlar,yuzler;
	
	yuzler=sayi/100;
	printf("%d\n",yuzler);
	
	onlar=(sayi/10)%10;
	printf("%d\n",onlar);
	
	birler=sayi%10;
	printf("%d",birler);
	
	
	
	
	
	return 0;
}
