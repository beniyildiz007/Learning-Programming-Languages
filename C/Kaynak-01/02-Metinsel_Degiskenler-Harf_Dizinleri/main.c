#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	/*
	char kitapadi[20]="Mufettis";
	char kitapyazar[10]="Gogol";
	
	printf("%s\n",kitapadi); // %s komutu C# dilindeki format komutu gibidir. Bulundu�u yere de�i�ken gelir (s = scan (g�r�nt�lemek))
	printf("%s\n",kitapyazar); // Alt sat�ra ge�me komutu da %s'nin yan�nda kullan�l�r.
	
	
	// Ayn� ekran ��kt�s�n� bu �ekilde yazarak da alabiliriz:
	printf(kitapadi);
	printf("\n");
	printf(kitapyazar);
	*/
	
	
	
	
	/*
	char kitaptur[10]="Tiyatro Kitabi";
	printf("Kitap Turu:   %s",kitaptur);
	// Output = Kitap Turu:   Tiyatro Ki
	// ��nk� belirledi�imiz [10] alan kadar veri tutulabilir
	*/
	
	
	
	
	
	char kitapad[20]="Avcunuzdaki Kelebek";
	char yazar[30]="Ahmet Serif Izgoren";
	char turu[10]="Hikaye";
	char sayfa[3]="124";
	char basimyil[4]="2001";
	
	printf("********* Kitap Tanitim *********\n\n");
	printf("Kitabin Adi: %s - Yazar: %s\n",kitapad,yazar);
	printf("Kitap Turu: %s\n",turu);
	printf("Sayfa Sayisi: %s\n",sayfa);
	printf("Basim Yili: %s\n",basimyil);
	
	
	
	return 0;
}
