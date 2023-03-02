# 01- Merhaba Dünya
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	/*
	printf("Merhaba Dunya"); // C dilinde türkçe karakterler desteklenmez!
	
	printf(" 13 Subat 2023 Istanbul"); // Her yeni yazılan komuttan sonra değişikliklerin uygulanması için Compile edlimesi gerekir!
	
	printf("\nC Programlama Dilini ogrenmeye basladik."); // \n komutu bir alt satıra geçmeyi sağlar.
	*/
	
	
	printf("******** Kisi Bilgileri ********");
	printf("\n\n");
	printf("Ad: Berkan Nihat\n");
	printf("Soyad: Yildiz\n");
	printf("Meslek: Ogretmen\n");
	printf("Maas: 15.000 TL\n");
	printf("Semt: Yenimahalle\n\n");
	printf("*********************************");
	
	return 0;
}

```
# 02- Metinsel Değişkenler ve Harf Dizinleri
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	/*
	char kitapadi[20]="Mufettis";
	char kitapyazar[10]="Gogol";
	
	printf("%s\n",kitapadi); // %s komutu C# dilindeki format komutu gibidir. Bulunduğu yere değişken gelir (s = scan (görüntülemek))
	printf("%s\n",kitapyazar); // Alt satıra geçme komutu da %s'nin yanında kullanılır.
	
	
	// Aynı ekran çıktısını bu şekilde yazarak da alabiliriz:
	printf(kitapadi);
	printf("\n");
	printf(kitapyazar);
	*/
	
	
	
	
	/*
	char kitaptur[10]="Tiyatro Kitabi";
	printf("Kitap Turu:   %s",kitaptur);
	// Output = Kitap Turu:   Tiyatro Ki
	// Çünkü belirlediğimiz [10] alan kadar veri tutulabilir
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

```
