#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	/*
	//Bir bakteri türü her saat baþý kendini ikiye bölerek çoðaltmaktadýr. Bu laboratuvarda 24 saat sonra kaç tane bakteri olur?
	int sayi=1,i;
	
	for(i=1;i<=24;i++){
		
		sayi*=2;
	}
	printf("%d",sayi); //Output = 16777216
	*/
	
	
	
	
	
	
	
	/*
	//Klavyeden 4 tane tam sayý alýp bunlarýn toplamýný bulan program
	int i,toplam=0,sayi;
	
	for(i=1;i<=4;i++){
		
		printf("%d. Sayi: ",i);
		scanf("%d",&sayi);
		toplam+=sayi;
	}
	printf("Toplam Sonuc: %d",toplam);
	*/
	
	
	
	
	
	
	/*
	//Klavyeden 0 girilene kadar girilen sayýlarý toplayan program
	int sayi,toplam=0;
	
	while(sayi!=0){
		
		printf("Sayi: ");
		scanf("%d",&sayi);
		toplam+=sayi;
	}
	printf("%d",toplam);
	*/
	
	
	
	
	
	
	
	//Bir otoparkta ücretlendirme þu þekildedir:
	//0-4 Saat: 10TL
	//5-8 Saat: 12Tl
	//9-12 Saat: 15TL
	//13++ Saat: 20TL
	//Klavyeden otoparkta kaç saat kaldýðý girilen aracýn ödemesi gerekn tutarý yazdýran program
	
	int saat;
	printf("Kac saat kaldiniz: ");
	scanf("%d",&saat);
	
	if(saat>0 && saat<=4){
		printf("10 TL Odeme Yapin");
	}
	if(saat>=5 && saat<=8){
		printf("12 TL Odeme Yapin");
	}
	if(saat>=9 && saat<=12){
		printf("15 TL Odeme Yapin");
	}
	if(saat>=13){
		printf("20 TL Odeme Yapin");
	}	
	
	
	
	
	
	
	
	
	
	
	
	
	
	return 0;
}
