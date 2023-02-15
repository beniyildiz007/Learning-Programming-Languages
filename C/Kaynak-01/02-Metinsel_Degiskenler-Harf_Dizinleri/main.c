#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	/*
	char kitapadi[20]="Mufettis";
	char kitapyazar[10]="Gogol";
	
	printf("%s\n",kitapadi); // %s komutu C# dilindeki format komutu gibidir. Bulunduðu yere deðiþken gelir (s = scan (görüntülemek))
	printf("%s\n",kitapyazar); // Alt satýra geçme komutu da %s'nin yanýnda kullanýlýr.
	
	
	// Ayný ekran çýktýsýný bu þekilde yazarak da alabiliriz:
	printf(kitapadi);
	printf("\n");
	printf(kitapyazar);
	*/
	
	
	
	
	/*
	char kitaptur[10]="Tiyatro Kitabi";
	printf("Kitap Turu:   %s",kitaptur);
	// Output = Kitap Turu:   Tiyatro Ki
	// Çünkü belirlediðimiz [10] alan kadar veri tutulabilir
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
