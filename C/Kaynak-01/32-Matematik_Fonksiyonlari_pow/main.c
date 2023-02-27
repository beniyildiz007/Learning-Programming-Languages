#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Girilen sayýnýn üssünü bulmak
	int x,y,sonuc;
	
	printf("Taban: ");
	scanf("%d",&x);
	
	printf("Us: ");
	scanf("%d",&y);
	
	sonuc=pow(x,y); //x'in y'ninci üssünü al
	printf("Sonuc: %d",sonuc);
	
	
	
	
	
	return 0;
}
