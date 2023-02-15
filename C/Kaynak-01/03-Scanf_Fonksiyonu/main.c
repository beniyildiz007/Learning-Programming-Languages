#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() { // main içerisindeki veirler silindiðinde de program çalýþabilir
	
	/*
	char kitapad[30];
	printf("Kitabin adini giriniz: ");
	scanf("%s",kitapad); // Girilen veriyi direkt olarak kitapad deðiþkenine aktarýr. C# dilindeki Console.ReadLine() gibi düþünülebilir.
	printf("Girmis oldugunuz kitap: %s",kitapad);
	// scanf avantajý: Türkçe karakter ile veri girildiðinde de yine ayný þekilde Türkçe karakterleri yazdýrabilir
	// scanf dezavantajý: Boþluktan sonrasýný algýlamaz. Yani Kitap adýna Fareler ve Ýnsanlar girerseniz sadece Fareler yazar.
	*/
	
	
	
	
	char Ad[10],Soyad[10],Yas[2],Sehir[13],Meslek[10];
	
	printf("Adiniz: ");
	scanf("%s",Ad);
	
	printf("Soyadiniz: ");
	scanf("%s",Soyad);
	
	printf("Yasiniz: ");
	scanf("%s",Yas);
	
	printf("Yasadiginiz Sehir: ");
	scanf("%s",Sehir);
	
	printf("Mesleginiz: ");
	scanf("%s",Meslek);
	
	
	printf("\n");
	
	printf("Adi: %s - Soyadi: %s\n",Ad,Soyad);
	printf("Yasi: %s\n",Yas);
	printf("Meslek: %s - Sehir: %s\n",Meslek,Sehir);
	
	
	
	
	return 0;
}
