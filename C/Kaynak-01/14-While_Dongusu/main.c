#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//1-10 aras�ndaki say�lar� while d�ng�s� ile ekrana yazd�rmak
	int i=1;
	while(i<=10){
		printf(" %d ",i);
		i++;
	}
	*/
	
	
	
	/*
	//1-20 aras�ndaki �ift yazd�ran fakat 14 say�s�n� yazd�rmayan program
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
