#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//En ve boy de�eri girilen d�rtgeni y�ld�zlar ile �izdirmek
	int en,boy,i,j;
	
	printf("En Degeri: ");
	scanf("%d",&en);
	printf("Boy Degeri: ");
	scanf("%d",&boy);
	
	for(i=1;i<=boy;i++){
		
		for(j=1;j<=en;j++){
			
			printf("*");
		}
		printf("\n");
	}
	*/
	
	
	
	
	//Taban degeri girilen dik ��geni y�ld�zlarla �izdirmek
	int i,j,taban;
	
	printf("Taban degerini giriniz: ");
	scanf("%d",&taban);
	
	for(i=1;i<=taban;i++){
		
		for(j=1;j<=i;j++){
			
			printf("*");
		}
		printf("\n");
	}
	
	
	
	return 0;
}
