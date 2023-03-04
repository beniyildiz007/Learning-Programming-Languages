#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	printf("********************");
	printf("\n");
	printf("**      MENU      **");
	printf("\n");
	printf("********************");
	printf("\n\n");
	
	printf("1.Toplama islemi\n");
	printf("2.Carpma islemi\n");
	printf("3.Kare bul\n");
	printf("4.Kup bul\n");
	printf("5.Denklem (5x^2+4x+3)");
	
	int secim,s1,s2,sonuc;
	printf("\n\nisleminiz: ");
	scanf("%d",&secim);
	switch(secim){
		case 1:
			printf("iki sayi girin: ");
			scanf("%d%d",&s1,&s2);
			sonuc=s1+s2;
			printf("Toplam: %d",sonuc);
			break;
		case 2:
			printf("iki sayi girin: ");
			scanf("%d%d",&s1,&s2);
			sonuc=s1*s2;
			printf("Carpim: %d",sonuc);
			break;
		case 3:
			printf("Karesi alinacak sayi: ");
			scanf("%d",&s1);
			sonuc=s1*s1;
			printf("Kare Sonuc: %d",&sonuc);
			break;
		case 4:
			printf("Karesi alinacak sayi: ");
			scanf("%d",&s1);
			sonuc=s1*s1*s1;
			printf("Kup Sonuc: %d",&sonuc);
			break;
		case 5:
			printf("X degerini girin: ");
			scanf("%d",&s1);
			sonuc=5*s1*s1+4*s1+3;
			printf("Denklem Sonucu: %d",sonuc);
			break;
			
			
	}
	
	
	
	
	
	
	
	return 0;
}
