#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//Klavyeden taban say�s� girilen dik ��geni y�ld�z(*) sembol� ile �izdiren program
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
	//1+5+9+13+...+81 dizisinin toplam�n� bulan program
	int i,toplam=0;
	
	for(i=1;i<=81;i+=4){
		toplam+=i;
	}
	printf("Toplam Deger: %d",toplam); //Output = 861
	*/
	
	
	
	
	
	
	
	//A�a��da verilen bir futbol tak�m�n�n 10 haftal�k ma� sonu�lar� tablosundaki de�erlere g�re ligden d���p d��medi�ini yazd�ran program:
	//12 puanda kald�ysa ligde kal�r, 12 puandan az ald�ysa lig d��er
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
	}//Output = Puan�n�z: 12 (LIGDE KALDINIZ)
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	return 0;
}
