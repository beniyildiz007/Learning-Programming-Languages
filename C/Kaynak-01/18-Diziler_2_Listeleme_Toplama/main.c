#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	int sayilar[]={5,7,3,4,5,2};
	
	int i;
	
	for(i=0;i<6;i++){
		printf("%d\n",sayilar[i]);
	}
	*/
	
	
	
	//Dizideki elemanlarý toplatma
	int sayilar[]={10,15,20,35};
	int toplam=0;
	int i;
	
	for(i=0;i<4;i++){
		toplam+=sayilar[i];
	}
	printf("Dizinin Toplami: %d",toplam); // Output = 80
	
	
	
	return 0;
}
