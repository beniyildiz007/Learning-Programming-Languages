#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() { // main i�erisindeki veirler silindi�inde de program �al��abilir
	
	/*
	char kitapad[30];
	printf("Kitabin adini giriniz: ");
	scanf("%s",kitapad); // Girilen veriyi direkt olarak kitapad de�i�kenine aktar�r. C# dilindeki Console.ReadLine() gibi d���n�lebilir.
	printf("Girmis oldugunuz kitap: %s",kitapad);
	// scanf avantaj�: T�rk�e karakter ile veri girildi�inde de yine ayn� �ekilde T�rk�e karakterleri yazd�rabilir
	// scanf dezavantaj�: Bo�luktan sonras�n� alg�lamaz. Yani Kitap ad�na Fareler ve �nsanlar girerseniz sadece Fareler yazar.
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
