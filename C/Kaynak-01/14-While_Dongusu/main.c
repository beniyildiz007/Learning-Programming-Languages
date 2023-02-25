#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//1-10 arasýndaki sayýlarý while döngüsü ile ekrana yazdýrmak
	int i=1;
	while(i<=10){
		printf(" %d ",i);
		i++;
	}
	*/
	
	
	
	/*
	//1-20 arasýndaki çift yazdýran fakat 14 sayýsýný yazdýrmayan program
	int i=1;
	while(i<=20){
		if(i!=14 && i%2==0){
			printf(" %d ",i);
		}
		i++;
	}
	*/
	
	
	
	
	
	
	//While ile faktoriyel bulma
	int sayi,faktoriyel;
	faktoriyel=1;
	sayi=6;
	
	while(sayi>1){
		faktoriyel*=sayi;
		sayi--;
	}
	printf("Sayimizin faktoriyeli: %d",faktoriyel);
	
	
	
	
	
	
	
	return 0;
}
