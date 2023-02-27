#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	//Matris oluþturmak ve yazdýrmak
	int matris[2][3]={10,20,30,40,50,60};
	
	int i,j;
	for(i=0;i<2;i++){
		
		for(j=0;j<3;j++){
			
			printf("%d ",matris[i][j]);
		}
		printf("\n");
	}
	
	
	
	return 0;
}
