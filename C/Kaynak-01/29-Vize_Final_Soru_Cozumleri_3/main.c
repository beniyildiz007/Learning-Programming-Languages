#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//Klavyeden taban sayýsý girilen dik üçgeni yýldýz(*) sembolü ile çizdiren program
	int i,j,yukseklik;
	printf("Yuksekligi girin: ");
	scanf("%d",&yukseklik);
	
	for(i=1;i<=yukseklik;i++){
		
		for(j=1;j<=i;j++){
			printf("*");
		}
		printf("\n");
	}
	*/
	
	
	
	
	
	
	/*
	//1+5+9+13+...+81 dizisinin toplamýný bulan program
	int i,toplam=0;
	
	for(i=1;i<=81;i+=4){
		toplam+=i;
	}
	printf("Toplam Deger: %d",toplam); //Output = 861
	*/
	
	
	
	
	
	
	
	//Aþaðýda verilen bir futbol takýmýnýn 10 haftalýk maç sonuçlarý tablosundaki deðerlere göre ligden düþüp düþmediðini yazdýran program:
	//12 puanda kaldýysa ligde kalýr, 12 puandan az aldýysa lig düþer
	//2 = Galibiyet(3 Puan) | 1 = Malubiyet(0 Puan) | 0 = Beraberlik(1 Puan)
	
	int skor[10]={2,1,0,0,2,1,1,2,1,0};
	int i,puan=0;
	
	for(i=0;i<10;i++){
		
		if(skor[i]==2){
			puan+=3;
		}
		if(skor[i]==0){
			puan+=1;
		}
	}
	if(puan>=12){
		printf("Puaniniz: %d (LIGDE KALDINIZ)",puan);
	}
	else{
		printf("Puaniniz: %d (LIGDEN DUSTUNUZ)",puan);
	}//Output = Puanýnýz: 12 (LIGDE KALDINIZ)
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	return 0;
}
