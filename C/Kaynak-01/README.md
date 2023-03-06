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

# Scanf Fonksiyonu
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() { // main içerisindeki veirler silindiğinde de program çalışabilir
	
	/*
	char kitapad[30];
	printf("Kitabin adini giriniz: ");
	scanf("%s",kitapad); // Girilen veriyi direkt olarak kitapad değişkenine aktarır. C# dilindeki Console.ReadLine() gibi düşünülebilir.
	printf("Girmis oldugunuz kitap: %s",kitapad);
	// scanf avantajı: Türkçe karakter ile veri girildiğinde de yine aynı şekilde Türkçe karakterleri yazdırabilir
	// scanf dezavantajı: Boşluktan sonrasını algılamaz. Yani Kitap adına Fareler ve İnsanlar girerseniz sadece Fareler yazar.
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
```

# Integer Değişkenler
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	/*
	int sayi;
	printf("%d",sayi); // Rakamsal ifadeleri belirtmek için %d kullanılır (d = decimal)
	//Output = 0
	//Eğer sayısal bir değişkene hiçbir değer atamazsak varsayılan değeri 0 olarak yazar.
	*/
	
	
	
	/*
	// Belirlenmiş olan iki sayıyı toplatma
	int s1,s2,toplam;
	s1=40;
	s2=80;
	toplam=s1+s2;
	
	printf("Toplam Sonuc: %d",toplam);
	*/
	
	
	
	
	
	/*
	//Dört işlem yaptırmak
	int s1,s2,topla,carp,fark,bol;
	
	s1=50;
	s2=10;
	
	topla=s1+s2;
	fark=s1-s2;
	carp=s1*s2;
	bol=s1/s2;
	
	printf("Toplam: %d\n",topla);
	printf("Fark: %d\n",fark);
	printf("Carpim: %d\n",carp);
	printf("Bolum: %d",bol);
	*/
	
	
	
	
	
	/*
	//Karenin alan ve çevresi
	int kenar,alan,cevre;
	kenar=10;
	alan=kenar*kenar;
	cevre=kenar*4;
	printf("Alan: %d\n",alan);
	printf("Cevre: %d",cevre);
	*/
	
	
	
	
	
	
	//Dikdörtgen alan ve çevresi
	int kisa,uzun,alan,cevre;
	kisa=8;
	uzun=12;
	alan=kisa*uzun;
	cevre=2*(kisa+uzun);
	printf("Alan: %d\n",alan);
	printf("Cevre: %d",cevre);	
	
	
	
	
	return 0;
}
```

# Integer Değişkenlerde Klavyeden Veri Girişi
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	// Kullanıcının girdiği 2 sayıyı topla çıkar çarp
	int s1,s2,toplam,fark,carpim;
	printf("Birinci sayiyi girin: ");
	scanf("%d",&s1); // Sayısal değişkenlerde %s yerine %d kullanılır ve degisken adından önce & sembolu koyulur.
	
	
	printf("Ikinci sayiyi girin: ");
	scanf("%d",&s2);
	
	toplam=s1+s2;
	fark=s1-s2;
	carpim=s1*s2;
	
	printf("Toplam: %d\n",toplam);
	printf("Fark: %d\n",fark);
	printf("Carpim: %d",carpim);
	*/
	
	
	
	/*
	// Klavyeden bir kenar uzunluğu girilen karenin alan ve çevresi
	int kenar,alan,cevre;
	
	printf("Karede Alan ve Cevre Hesabi\n\n");
	
	printf("Bir kenari girin: ");
	scanf("%d",&kenar);
	
	alan=kenar*kenar;
	cevre=kenar*4;
	
	printf("Karenin Alani: %d\n",alan);
	printf("Karenin Cevresi: %d",cevre);
	*/
	
	
	
	
	/*
	// Klavyeden 3 sınav notu girilen öğrencinin ortalaması
	int s1,s2,s3,ort;
	
	printf("Birinci Sinav: ");
	scanf("%d",&s1);
	
	printf("Ikinci Sinav: ");
	scanf("%d",&s2);
	
	printf("Ucuncu Sinav: ");
	scanf("%d",&s3);
	
	ort=(s1+s2+s3)/3;
	
	printf("Ortalamaniz: %d",ort);
	*/
	
	
	
	
	
	
	// Bir sinema salonundaki harcamaya göre ücretlendirme özetini çıkaran program
	int su,kola,bilet,misir,toplam;
	
	printf("Misir Adedi: ");
	scanf("%d",&misir);
	
	printf("Kola Adedi: ");
	scanf("%d",&kola);
	
	printf("su Adedi: ");
	scanf("%d",&su);
	
	printf("Bilet Adedi: ");
	scanf("%d",&bilet);
	
	toplam=misir*2+kola*2+su*1+bilet*8; // Ekonominin henüz cebimizi delip geçmediği zamanlar...
	
	printf("Toplam Borcunuz: %d",toplam);
	printf(" TL ...");
	
	
	
	
	
	
	
	
	return 0;
}
```
