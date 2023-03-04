#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	FILE *metinbelgesi;
	char veri1[20]="Bilgisayar ";
	char veri2[20]="Muhendisligi ";
	char veri3[20]="Bolumu";
	
	metinbelgesi=fopen("C:\\Users\\nihat\\OneDrive\\Belgeler\\GitHub\\Learning-Programming-Languages\\C\\58-Dosya_Islemleri_5_fputs_Kullanimi\\bilgi.txt","w");
	
	fputs(veri1,metinbelgesi);
	fputs(veri2,metinbelgesi);
	fputs(veri3,metinbelgesi);
	
	fclose(metinbelgesi);
	
	
	
	
	return 0;
}
