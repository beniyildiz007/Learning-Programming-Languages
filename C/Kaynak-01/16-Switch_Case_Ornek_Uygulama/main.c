#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	int s1,s2,sonuc;
	char islem;
	s1=75;
	s2=15;
	printf("Yapmak istediginiz islemi girin: ");
	scanf("%s",&islem);
	
	switch(islem){
		case '+':
			sonuc=s1+s2;
			printf("Sonuc: %d",sonuc);
			break;
		case '-':
			sonuc=s1-s2;
			printf("Sonuc: %d",sonuc);
			break;
		case '*':
			sonuc=s1*s2;
			printf("Sonuc: %d",sonuc);
			break;
		case '/':
			sonuc=s1/s2;
			printf("Sonuc: %d",sonuc);
			break;
		default:
			printf("Yanlis tusa bastiniz!");
			break;
	}
	
	
	
	
	return 0;
}
