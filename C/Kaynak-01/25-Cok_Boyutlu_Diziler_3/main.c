#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	//Kullan�c�n�n girmi� oldu�u de�erlere g�re matris olu�turup ekranda g�r�nt�lemek
	int satir,sutun,i,j,k,n;
	
	printf("Satir sayisi: ");
	scanf("%d",&satir);
	
	printf("Sutun sayisi: ");
	scanf("%d",&sutun);
	
	
	int matris[satir][sutun];
	
	for(i=0;i<satir;i++){
		
		for(j=0;j<sutun;j++){
			
			printf("\n[%d][%d] ==> ",i+1,j+1);
			scanf("%d",&matris[i][j]);
		}
	}
	
	printf("\n\nOlusan Matris:\n");
	
	for(k=0;k<satir;k++){
		
		for(n=0;n<sutun;n++){
			
			printf("%d ",matris[k][n]);
		}
		printf("\n");
	}
	
	
	
	
	return 0;
}
