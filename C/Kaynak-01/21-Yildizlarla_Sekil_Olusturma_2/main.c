#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	//Y�ld�zlarla yatay piramit olu�turma
	int i,j,k,l;
	
	for(i=1;i<=10;i++){
		
		for(j=1;j<=i;j++){
			
			printf("*");
		}
		printf("\n");
	}
	
	for(k=1;k<=10;k++){
		
		for(l=10;l>=k;l--){
			
			printf("*");
		}
		printf("\n");
	}
	
	
	return 0;
}
