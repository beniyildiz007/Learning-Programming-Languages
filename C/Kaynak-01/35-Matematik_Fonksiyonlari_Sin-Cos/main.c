#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	double derece,sonucSin,sonucCos;
	
	printf("Dereceyi girin: ");
	scanf("%lf",&derece);
	
	sonucSin=sin(derece);
	printf("Sinus: %lf\n",sonucSin);
	
	sonucCos=cos(derece);
	printf("Cosinus: %lf\n",sonucCos);
	
	
	
	return 0;
}
