#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */


//Girilen sayýnýn kübünü bulan fonksiyon
int kupbul(int sayi){
	
	int sonuc=sayi*sayi*sayi;
	return sonuc;
}


//Kýsa ve uzun kenar uzunluklarý girilen dikdörtgeni çizdiren fonksiyon
void dortgen(int kisa,int uzun){
	
	int i,j;
	for(i=0;i<uzun;i++){
		for(j=0;j<kisa;j++){
			printf("*");
		}
		printf("\n");
	}
}



int main() {
	
	
	int s;
	printf("Sayiyi girin: ");
	scanf("%d",&s);
	
	printf("\nSonuc: %d\n\n",kupbul(s));
	
	
	
	dortgen(7,18);
	
	
	
	return 0;
}
