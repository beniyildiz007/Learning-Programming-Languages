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

# 03- Scanf Fonksiyonu
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

# 04- Integer Değişkenler
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

# 05- Integer Değişkenlerde Klavyeden Veri Girişi
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
# 06- Float Değişkenler (Türkçe Dil Desteği Ayarları)
```c
#include <stdio.h>
#include <stdlib.h>
#include <locale.h> // Türkçe karakter uyumluluğu için kütüphanemizi entegre ediyoruz

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	setlocale(LC_ALL,"turkish"); // Entegre ettiğimiz kütüphanemizi Türkçe dili olarak ayarlıyoruz
	
	
	/*
	float s1,s2,s3,ort;
	s1=75;
	s2=80;
	s3=81;
	
	ort=(s1+s2+s3)/3;
	printf("Ortalama: %f",ort); // Float türündeki değişkenler için %f kullanılır
	*/
	
	
	
	
	
	// İdeal kilo hesaplama
	printf("İdeal Kilo Hesaplama");
	printf("\n");
	
	float boy, yas, ideal;
	boy=165;
	yas=24;
	ideal=(boy-100+yas/10)*0.9;
	
	printf("İdeal kilonuz: %f",ideal);
	
	
	
	
	
	return 0;
}





```

# 07- Float Değişkenler 2
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	// Ondalıklı girilen sayıları toplatma
	float s1,s2,toplam;
	
	printf("ilk sayiyi girin: ");
	scanf("%f",&s1);
	
	printf("ikinci sayiyi girin: ");
	scanf("%f",&s2);
	
	toplam=s1+s2;
	printf("Toplam Sonucu: %f",toplam);
	*/
	
	
	
	
	/*
	// Maaşa gelen %12'lik zamma göre yeni maaşı hesaplamak
	printf("******* Zam Maas Hesabi *******");
	printf("\n\n");
	float maas,yenimaas;
	printf("Maasinizi girin: ");
	scanf("%f",&maas);
	yenimaas=maas+maas*12/100;
	printf("Yeni Maasiniz: %f",yenimaas);
	*/
	
	
	
	
	/*
	// Çemberde alan ve çevre hesabı yapmak
	printf("Cemberde Alan ve Cevre Hesabi\n");
	printf("*********************************\n");
	
	float r,pi,alan,cevre;
	pi=3.14;
	printf("Yaricap Degeri: ");
	scanf("%f",&r);
	
	alan=pi*r,r;
	cevre=2*pi*r;
	
	printf("Alan: %f\n",alan);
	printf("Cevre: %f",cevre);
	*/
	
	
	
	
	
	
	// YGS-1 puan türü hesaplama
	float turkce,matematik,sosyal,fen,taban,toplampuan;
	
	taban=100.160;
	printf("Turkce Netiniz: ");
	scanf("%f",&turkce);
	
	printf("Matematik Netiniz: ");
	scanf("%f",&matematik);
	
	printf("Sosyal Bilgiler Netiniz: ");
	scanf("%f",&sosyal);
	
	printf("Fen Bilimleri Netiniz: ");
	scanf("%f",&fen);
	
	toplampuan=turkce*1.999+matematik*3.998+sosyal*1+fen*2.999+taban;
	printf("YGS-1 Puan Turunde Sonucunuz: %f",toplampuan);
	
	
	
	
	return 0;
}
```

# 08- Karar Yapıları if-else
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	

	printf("Ogrenci ortalama hesap bilgi sistemi\n\n");
	
	int s1,s2,ort;
	
	printf("1. Sinav sonucunu girin: ");
	scanf("%d",&s1);
	
	printf("2. Sinav sonucunu girin: ");
	scanf("%d",&s2);
	
	ort=(s1+s2)/2;
	
	printf("Ortalam puaniniz: %d\n\n",ort);
	
	if(ort>=50){
		printf("Tebrikler, geçtiniz!");
	}else{
		printf("Maalesef kaldin, seni tembel teneke...");
	}
	
	
	
	
	
	return 0;
}
```

# 09- Karar Yapıları 2
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	// Klavyeden girilen sayının 3'e ve 5'e tam bölünüp bölünmediğini kontrol eden program
	int sayi;
	printf("Sayiyi giriniz: ");
	scanf("%d",&sayi);
	
	if(sayi%3==0 && sayi%5==0){
		printf("Girdiginiz sayi 3 ve 5'e tam bolunur.");
	}else{
		printf("Girdiginiz sayi 3 ve 5'e tam bolunmez.");
	}
	*/
	
	
	
	
	
	
	/*
	// Klavyeden girilen sayının 3'e veya 5'e veya 7'ye tam bölünüp bölünmediğini kontrol eden program
	int sayi;
	printf("Sayiyi giriniz: ");
	scanf("%d",&sayi);
	
	if(sayi%3==0 || sayi%5==0 || sayi%7==0){
		printf("Girdiginiz sayi 3 veya 5 veya 7'ye tam bolunur.");
	}else{
		printf("Girdiginiz sayi 3 veya 5 veya 7'ye tam bolunmez.");
	}
	*/
	
	
	
	
	// Klavyeden girilen dereceye göre suyun durumunu yazdıran program
	printf("********* Suyun Durumu *********\n\n");
	
	int su;
	
	printf("Sicaklik degerini giriniz: ");
	scanf("%d",&su);
	
	if(su<=0){
		printf("Suyunuz buz halindedir.");
	}
	if(su>0 && su<100){
		printf("Suyunuz sivi halindedir.");
	}
	if(su>=100){
		printf("Suyunuz buhar halindedir");
	}
	
	
	
	
	
	
	return 0;
}
```

# 10- Döngüler 1
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	// Ekrana 20 kere Merhaba Antalya yazdıran program
	int k;
	for(k=1;k<=20;k++){
		printf("%d - Merhaba Antalya\n",k);
	}
	*/
	
	
	
	
	int i;
	for(i=0;i<=30;i+=5){ // i değerimiz 5'er 5'er artsın
		printf("%d - iyi calismalar dilerim\n",i); // 7 defa yazar çünkü 0 ve 30 dahildir
	}
	
	
	
	
	return 0;
}
```

# 11- Döngüler 2
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//Toplama buldurma
	int sayac=0;
	int i;
	for(i=1;i<=10;i++){
		sayac+=i;
	}
	printf("Sayac= %d",sayac);
	// Output = 55
	*/
	
	
	
	
	/*
	//Faktöriyel bulma
	int sayac=1;
	int i;
	for(i=1;i<=6;i++){
		sayac*=i;
	}
	printf("6 Sayisinin faktoriyeli= %d",sayac);
	//Output = 720
	*/
	
	
	
	
	
	//Kullanıcının girdiği bir sayının faktöriyelini bulma
	int i,sayi;
	int faktoriyel=1;
	
	printf("Faktoriyeli alinacak sayi: ");
	scanf("%d",&sayi);
	
	for(i=1;i<=sayi;i++){
		faktoriyel*=i;
	}
	printf("Girdiginiz sayinin faktoriyeli= %d",faktoriyel);
	
	
	
	
	
	
	return 0;
}
```

# 12- Döngüler 3
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	//Fibonacci serisinin ilk 10 elemanını listeleyen program
	
	int a,b,c,i;
	a=1;
	b=1;
	
	printf("%d\n",a);
	printf("%d\n",b);
	
	for(i=1;i<=8;i++){ //10 eleman istendiği için 8 yazdık çünkü ilk 2 eleman zaten 1 ve bunları yukarıda yazdırmıştık
		c=a+b;
		a=b;
		b=c;
		printf("%d\n",c);
	}
	
	
	return 0;
}
```

# 13- Mod Operatörü Kullanımı
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	/*
	//1-50 arasında 5'e tam bölünen sayıları yazdıran program
	int i;
	for(i=1;i<=50;i++){
		if(i%5==0){
			printf("%d\n",i);
		}
	}
	*/
	
	
	
	
	//3 basamaklı bir sayıyı basamak değerlerine ayıran program
	int sayi;
	sayi=574;
	int birler,onlar,yuzler;
	
	yuzler=sayi/100;
	printf("%d\n",yuzler);
	
	onlar=(sayi/10)%10;
	printf("%d\n",onlar);
	
	birler=sayi%10;
	printf("%d",birler);
	
	
	
	
	
	return 0;
}
```

# 14- While Döngüsü
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//1-10 arasındaki sayıları while döngüsü ile ekrana yazdırmak
	int i=1;
	while(i<=10){
		printf(" %d ",i);
		i++;
	}
	*/
	
	
	
	/*
	//1-20 arasındaki çift yazdıran fakat 14 sayısını yazdırmayan program
	int i=1;
	while(i<=20){
		if(i!=14 && i%2==0){
			printf(" %d ",i);
		}
		i++;
	}
	*/
	
	
	
	
	
	
	//While ile faktoriyel bulma
	int sayi,faktoriyel;
	faktoriyel=1;
	sayi=6;
	
	while(sayi>1){
		faktoriyel*=sayi;
		sayi--;
	}
	printf("Sayimizin faktoriyeli: %d",faktoriyel);
	
	
	
	
	
	
	
	return 0;
}
```

# 15- Switch-Case
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	int sayi;
	printf("Lufen ay numarasini giriniz: ");
	scanf("%d",&sayi);
	
	switch(sayi){
		case 1:printf("Ocak"); break;
		case 2:printf("Subat"); break;
		case 3:printf("Mart"); break;
		case 4:printf("Nisan"); break;
		case 5:printf("Mayis"); break;
		case 6:printf("Haziran"); break;
		case 7:printf("Temmuz"); break;
		case 8:printf("Agustos"); break;
		case 9:printf("Eylul"); break;
		case 10:printf("Ekim"); break;
		case 11:printf("Kasim"); break;
		case 12:printf("Aralik"); break;
		default:printf("Hatali sayi girisi!"); break;
	}
	*/
	
	
	
	
	
	char ders;
	printf("Ders Kodu: ");
	scanf("%s",&ders);
	
	switch(ders){
		case 't':printf("Turkce"); break;
		case 'm':printf("Matematik"); break;
		case 'f':printf("Fen Bilgisi"); break;
		case 's':printf("Sosyal Bilgiler"); break;
		default: printf("Hatali ya da Buyuk Harf Girdisi!");
		break;
	}
	
	
	
	
	return 0;
}
```

# 16- Switch-Case Örnek Uygulama
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	int s1,s2,sonuc;
	char islem;
	s1=75;
	s2=15;
	printf("Yapmak istediginiz islemi girin: ");
	scanf("%s",&islem);
	
	switch(islem){
		case '+':
			sonuc=s1+s2;
			printf("Sonuc: %d",sonuc);
			break;
		case '-':
			sonuc=s1-s2;
			printf("Sonuc: %d",sonuc);
			break;
		case '*':
			sonuc=s1*s2;
			printf("Sonuc: %d",sonuc);
			break;
		case '/':
			sonuc=s1/s2;
			printf("Sonuc: %d",sonuc);
			break;
		default:
			printf("Yanlis tusa bastiniz!");
			break;
	}
	
	
	
	
	return 0;
}
```

# 17- Diziler 1
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	/*
	int tekrakamlar[]={1,3,5,7,9};
	//printf("%d",tekrakamlar); // Output = 6487552
	printf("%d",tekrakamlar[0]); // Output = 1
	*/
	
	
	
	/*
	char sehir[]={'a','n','k','a','r','a'};
	printf("%s",sehir); // Output = ankara
	*/
	
	
	
	
	/*
	char sehir[4]={'a','n','k','a','r','a'};
	printf("%s",sehir); // Output = anka
	*/
	
	
	
	
	int sayilar[4]; // Dizimizin 4 elemanlı bir dizi olacağını söylüyoruz
	sayilar[0]=24;
	sayilar[1]=895;
	sayilar[2]=774;
	sayilar[3]=662;
	printf("%d",sayilar[2]); // Output = 774	
	
	
	
	
	return 0;
}
```

# 18- Diziler 2 (Listeleme ve Toplama)
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	int sayilar[]={5,7,3,4,5,2};
	
	int i;
	
	for(i=0;i<6;i++){
		printf("%d\n",sayilar[i]);
	}
	*/
	
	
	
	//Dizideki elemanları toplatma
	int sayilar[]={10,15,20,35};
	int toplam=0;
	int i;
	
	for(i=0;i<4;i++){
		toplam+=sayilar[i];
	}
	printf("Dizinin Toplami: %d",toplam); // Output = 80
	
	
	
	return 0;
}
```

# 19- Diziler 3
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//Klavyeden girilen şehirleri listeleyen dizi programı
	char sehir[3][15];
	int i;
	for(i=0;i<3;i++){
		printf("%d. Sehri Giriniz: ",i+1);
		scanf("%s",&sehir[i]);
	}
	printf("\n\n");
	
	for(i=0;i<3;i++){
		printf("%d. Sehir: %s\n",i+1,sehir[i]);
	}
	*/
	
	
	
	
	
	//Klavyeden dizi elemanları kadar sayı girilmesi ve listelenmesi
	int dizi[100];
	int i, sayi;
	
	printf("Eleman Sayisi: ");
	scanf("%d",&sayi);
	
	for(i=0;i<sayi;i++){
		printf("Dizinin %d. degerini girin: ",i+1);
		scanf("%d",&dizi[i]);
	}
	
	printf("\n\n");
	
	for(i=0;i<sayi;i++){
		printf("%d ",dizi[i]);
	}
	
	
	
	
	return 0;
}
```

# 20- Yıldızlarla Şekil Oluşturma 1
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Yıldızlarla dik üçgen oluşturma
	int i,j;
	for(i=1;i<=10;i++){
		
		for(j=1;j<=i;j++){
			
			printf("*");
		}
		printf("\n");
	}
	
	
	
	return 0;
}
```

# 21- Yıldızlarla Şekil Oluşturma 2
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	//Yıldızlarla yatay piramit oluşturma
	int i,j,k,l;
	
	for(i=1;i<=10;i++){
		
		for(j=1;j<=i;j++){
			
			printf("*");
		}
		printf("\n");
	}
	
	for(k=1;k<=10;k++){
		
		for(l=10;l>=k;l--){
			
			printf("*");
		}
		printf("\n");
	}
	
	
	return 0;
}
```

# 22- Yıldızlarla Şekil Oluşturma 3
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//En ve boy değeri girilen dörtgeni yıldızlar ile çizdirmek
	int en,boy,i,j;
	
	printf("En Degeri: ");
	scanf("%d",&en);
	printf("Boy Degeri: ");
	scanf("%d",&boy);
	
	for(i=1;i<=boy;i++){
		
		for(j=1;j<=en;j++){
			
			printf("*");
		}
		printf("\n");
	}
	*/
	
	
	
	
	//Taban degeri girilen dik üçgeni yıldızlarla çizdirmek
	int i,j,taban;
	
	printf("Taban degerini giriniz: ");
	scanf("%d",&taban);
	
	for(i=1;i<=taban;i++){
		
		for(j=1;j<=i;j++){
			
			printf("*");
		}
		printf("\n");
	}
	
	
	
	return 0;
}
```

# 23- Çok Boyutlu Diziler 1
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	int dizi[2][2];
	
	dizi[0][0]=10;
	dizi[0][1]=20;
	dizi[1][0]=30;
	dizi[1][1]=40;
	
	printf("Matrisi 0-0 degeri: %d\n",dizi[0][0]);
	printf("Matrisi 0-1 degeri: %d\n",dizi[0][1]);
	printf("Matrisi 1-0 degeri: %d\n",dizi[1][0]);
	printf("Matrisi 1-1 degeri: %d\n",dizi[1][1]);
	
	
	
	return 0;
}
```

# 24- Çok Boyutlu Diziler 2
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	//Matris oluşturmak ve yazdırmak
	int matris[2][3]={10,20,30,40,50,60};
	
	int i,j;
	for(i=0;i<2;i++){
		
		for(j=0;j<3;j++){
			
			printf("%d ",matris[i][j]);
		}
		printf("\n");
	}
	
	
	
	return 0;
}
```

# 25- Çok Boyutlu Diziler 3
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	//Kullanıcının girmiş olduğu değerlere göre matris oluşturup ekranda görüntülemek
	int satir,sutun,i,j,k,n;
	
	printf("Satir sayisi: ");
	scanf("%d",&satir);
	
	printf("Sutun sayisi: ");
	scanf("%d",&sutun);
	
	
	int matris[satir][sutun];
	
	for(i=0;i<satir;i++){
		
		for(j=0;j<sutun;j++){
			
			printf("\n[%d][%d] ==> ",i+1,j+1);
			scanf("%d",&matris[i][j]);
		}
	}
	
	printf("\n\nOlusan Matris:\n");
	
	for(k=0;k<satir;k++){
		
		for(n=0;n<sutun;n++){
			
			printf("%d ",matris[k][n]);
		}
		printf("\n");
	}
	
	
	
	
	return 0;
}
```

# 26- Çok Boyutlu Diziler 4
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	//Oluşturulan iki matris değerini birbirleri ile toplamak
	int m1[2][2]={10,12,15,18};
	int m2[2][2]={11,17,25,28};
	int toplam[2][2];
	
	int i,j,k,l;
	
	for(i=0;i<2;i++){
		
		for(j=0;j<2;j++){
			
			toplam[i][j]=m1[i][j]+m2[i][j];
		}
	}
	
	for(k=0;k<2;k++){
		
		for(l=0;l<2;l++){
			printf("%d ",toplam[k][l]);
		}
		printf("\n");
	}
	
	
	
	return 0;
}
```

# 27- Vize & Final Soru Çözümleri 1
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	/*
	//Üç basamaklı ve rakamları birbirinden farklı kaç tane sayı olduğunu bulan program
	int sayac=0,i,a,b,c,sayi;
	
	for(i=100;i<=999;i++){
		
		a=i/100;
		b=(i/10)%10;
		c=i%10;
		
		if(a!=b && a!=c && b!=c){
			
			sayac++;	
		}
	}
	printf("%d",sayac); //Output = 648
	*/
	
	
	
	
	/*
	//Klavyeden girilen sayının tam bölenlerini bulan program
	int sayi,i;
	printf("Sayiyi giriniz: ");
	scanf("%d",&sayi);
	
	for(i=1;i<=sayi;i++){
		
		if(sayi%i==0){
			
			printf("%d\n",i);
		}
	}
	*/
	
	
	
	
	
	
	
	//Klavyeden girilen sayının küpünü alan program
	int sayi,sonuc;
	printf("sayiyi giriniz: ");
	scanf("%d",&sayi);
	
	sonuc=sayi*sayi*sayi;
	printf("%d",sonuc);	
	
	
	
	
	
	
	
	return 0;
}
```

# 28- Vize & Final Soru Çözümleri 2
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	/*
	//Bir bakteri türü her saat başı kendini ikiye bölerek çoğaltmaktadır. Bu laboratuvarda 24 saat sonra kaç tane bakteri olur?
	int sayi=1,i;
	
	for(i=1;i<=24;i++){
		
		sayi*=2;
	}
	printf("%d",sayi); //Output = 16777216
	*/
	
	
	
	
	
	
	
	/*
	//Klavyeden 4 tane tam sayı alıp bunların toplamını bulan program
	int i,toplam=0,sayi;
	
	for(i=1;i<=4;i++){
		
		printf("%d. Sayi: ",i);
		scanf("%d",&sayi);
		toplam+=sayi;
	}
	printf("Toplam Sonuc: %d",toplam);
	*/
	
	
	
	
	
	
	/*
	//Klavyeden 0 girilene kadar girilen sayıları toplayan program
	int sayi,toplam=0;
	
	while(sayi!=0){
		
		printf("Sayi: ");
		scanf("%d",&sayi);
		toplam+=sayi;
	}
	printf("%d",toplam);
	*/
	
	
	
	
	
	
	
	//Bir otoparkta ücretlendirme şu şekildedir:
	//0-4 Saat: 10TL
	//5-8 Saat: 12Tl
	//9-12 Saat: 15TL
	//13++ Saat: 20TL
	//Klavyeden otoparkta kaç saat kaldığı girilen aracın ödemesi gerekn tutarı yazdıran program
	
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
```

# 29- Vize & Final Soru Çözümleri 3
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//Klavyeden taban sayısı girilen dik üçgeni yıldız(*) sembolü ile çizdiren program
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
	//1+5+9+13+...+81 dizisinin toplamını bulan program
	int i,toplam=0;
	
	for(i=1;i<=81;i+=4){
		toplam+=i;
	}
	printf("Toplam Deger: %d",toplam); //Output = 861
	*/
	
	
	
	
	
	
	
	//Aşağıda verilen bir futbol takımının 10 haftalık maç sonuçları tablosundaki değerlere göre ligden düşüp düşmediğini yazdıran program:
	//12 puanda kaldıysa ligde kalır, 12 puandan az aldıysa lig düşer
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
	}//Output = Puanınız: 12 (LIGDE KALDINIZ)
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	return 0;
}
```

# 30- Vize & Final Soru ÇÖzümleri 4
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	//Bir havayolu şirketi yolcuları için bagaj sınırlaması uygulamaktadır.
	//Her yolcunun el için 8kg, normal için 15kg bagaj hakkı bulunmaktadır.
	//Eğer yolcular el hakkını geçerse kg başına 4TL, normal haklarını geçerse kg başına 5TL ödeme yapacaklardır.
	//Buna göre klavyeden el ve normal bagaj kiloları girilen yolcunun ödemesi gereken tutarı yazdıran programı yazınız.
	int normal,el,normaltutar,eltutar,toplam;
	printf("El bagaj kg: ");
	scanf("%d",&el);
	
	printf("Normal bagaj kg: ");
	scanf("%d",&normal);
	
	if(normal<15){
		normaltutar=0;
	}
	else{
		normaltutar=(normal-15)*5;
	}
	
	if(el<8){
		eltutar=0;
	}
	else{
		eltutar=(el-8)*4;
	}
	toplam=normaltutar+eltutar;
	
	printf("Toplam Ekstra Odemeniz: %d TL, iyi yolculuklar...",toplam);
	*/
	
	
	
	
	
	
	/*
	//Klavyeden birbirlerinden farklı 2 sayı girilmesini sağlayan ve bu iki sayı arasındaki
	//(iki sayı dahil) tamsayıların toplamını hesaplayıp ekrana yazdıran programı yazınız.
	int s1,s2,buyuk,kucuk,i,toplam=0;
	
	yeniden:
		printf("1. Sayi: ");
		scanf("%d",&s1);
		
		printf("2. Sayi: ");
		scanf("%d",&s2);
		
	if(s1==s2){
		goto yeniden;
	}
	else{
		if(s1>s2){
			buyuk=s1;
			kucuk=s2;
		}
		else{
			buyuk=s2;
			kucuk=s1;
		}
	}
	
	for(i=kucuk;i<=buyuk;i++){
		toplam+=i;
	}
	printf("Toplam: %d",toplam);
	*/
	
	
	
	
	
	
	
	/*
	//Heybeliada'da bulunan yazılım evi otelinde kış mevsiminden 320 kişi kalmıştır.
	//İlkbaharda kış mevsiminin dörtte biri, yaz mevsiminde ilkbaharın 8 katı ve sonbaharda yaz mevsiminin 10'da biri kadar kişi kaldığına göre
	//bu otelde 1 yıl içerisinde toplam kaç kişi kalmıştır?
	int yaz,kis,ilkbahar,sonbahar,toplam;
	kis=320;
	ilkbahar=kis/4;
	yaz=ilkbahar*8;
	sonbahar=yaz/10;
	
	toplam=kis+ilkbahar+sonbahar+yaz;
	printf("Toplam: %d",toplam); //Output = 1104
	*/
	
	
	
	
	
	
	
	//Klavyeden girilen 3 basamaklı bir sayının basamak değerleri toplamını bulan programı yazınız.
	int birler,onlar,yuzler,toplam,sayi;
	
	printf("Sayi: ");
	scanf("%d",&sayi);
	
	birler=sayi%10;
	onlar=(sayi/10)%10;
	yuzler=sayi/100;
	
	toplam=birler+onlar+yuzler;
	
	printf("Basamak Degerleri Toplami: %d",toplam);	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	return 0;
}
```

# 31- Matematik Fonksiyonları (Kök Alma)
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Girilen sayının karekökünü bulan program
	int sayi;
	double sonuc;
	printf("Sayiyi girin: ");
	scanf("%d",&sayi);
	sonuc=sqrt(sayi);
	printf("Sayinizin Karekoku: %.4f",sonuc); //%.4f komutu bize virgülden sonra 4 basamak yazdırır
	
		
	

	return 0;
}
```

# 32- Matematik Fonksiyonları (Kuvvet Alma)
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Girilen sayının üssünü bulmak
	int x,y,sonuc;
	
	printf("Taban: ");
	scanf("%d",&x);
	
	printf("Us: ");
	scanf("%d",&y);
	
	sonuc=pow(x,y); //x'in y'ninci üssünü al
	printf("Sonuc: %d",sonuc);
	
	
	
	
	
	return 0;
}
```

# 33- Matematik Fonksiyonları (Üste ve Alta Yuvarlama)
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Üste ve alta yuvarlama işlemi
	double sayi,sonuc1,sonuc2;
	
	printf("Degeri girin: ");
	scanf("%lf",&sayi);
	sonuc1=floor(sayi); //Sayıyı alta yuvarlama (Floor=Zemin)
	sonuc2=ceil(sayi); //Sayıyı üste yuvarlama (Ceil=Tavan)
	printf("Alt Sonuc: %.f\n",sonuc1);
	printf("Ust Sonuc: %.f",sonuc2);	
	
	
	
	return 0;
}
```

# 34- Matematik Fonksiyonları (Logaritma ve Mutlak Değer)
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Mutlak değer bulma
	double sayi,sonuc,logaritma;
	printf("Sayiyi girin: ");
	scanf("%lf",&sayi);
	sonuc=fabs(sayi);
	printf("Mutlak Deger Sonuc: %.lf",sonuc);
	
	
	//Logaritma
	logaritma=log(sayi);
	printf("\nSonuc Logaritma: %.7lf",logaritma);
	
	
	
	
	
	return 0;
}
```

# 35- Matematik Fonksiyonları (Sinüs ve Cosinüs)
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	double derece,sonucSin,sonucCos;
	
	printf("Dereceyi girin: ");
	scanf("%lf",&derece);
	
	sonucSin=sin(derece);
	printf("Sinus: %lf\n",sonucSin);
	
	sonucCos=cos(derece);
	printf("Cosinus: %lf\n",sonucCos);
	
	
	
	return 0;
}
```

# 36- Puts & Gets Fonksiyonları
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	//gets-puts fonksiyonları yazılan metni bütünü ile alır (boşluklar dahil)
	char bilgi[10];
	printf("Bilgiyi girin: ");
	gets(bilgi);
	printf("\n\n");
	puts(bilgi);
	
	
	//İkinci yöntem
	char bilgi2[10];
	printf("Bilgiyi girin: ");
	scanf("%[^\n]",bilgi2); //Bu sayede aynı gets-puts yöntemindeki gibi boşluktan sonraki karakterler de alınır
	printf("%s",bilgi2);
	
	
	//İki yöntemde de değişkene 10 karakterlik kısıtlama getirmeme rağmen girdiğim bütün veriyi aldı ve hepsini yazdırdı
	//Nedenini çözemedim, araştırmalarıma göre editör kaynaklı olduğu söyleniyor.
	
	
	
	return 0;
}
```

# 37- String Biçimlendirilmiş Kullanımlar
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	char kitap[40];
	printf("Ad: ");
	scanf("%s",kitap);
	
	printf("%s",kitap); //Direkt olarak girilen kitabı yazar
	printf("\n");
	
	printf("%18s",kitap); //Kitap için 18 karakter ayırır, eğer kitap 18 karakterden küçükse sol tarafı boşluklarla doldurur
	printf("\n");
	
	printf("%18.5s",kitap); //Yukarıdakinin aynısı fakat burada kitap için girdiğimiz değerin yalnızca 5 karakterini alır
	printf("\n");
	
	printf("%-18s",kitap); //Yüzdelik değer eksi(-) olarak yazılırsa boşluğu soldan değil sağdan verir

	
	return 0;
}
```

# 38- StrLen Fonksiyonu
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	printf("Katar Uzunlugu: %d",strlen("Merhaba Dunya")); //Output = 13 (Boşlukları da sayar)
	
	
	
	char kelime[100];
	printf("\nKelimeyi girin: ");
	scanf("%s",kelime);
	printf("Girilen kelimenin uzunlugu: %d",strlen(kelime));
	//"Merhaba Dunya" cümlesini burada yazınca sonuç 7 çıkar çünkü scanf boşluk ve sonrasını almaz
	//Bunun için gets-puts kullanılabilir.
	
	
	
	return 0;
}
```

# 39- StrCpy & StrnCpy Fonksiyonları
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	/*
	char kaynak[30]="Merhaba Antalya";
	char kopya[30]="";
	
	strcpy(kopya,kaynak); //strcpy = String Copy
	printf("%s",kopya);
	printf("\n");
	*/
	
	
	
	char nereden[30]="Merhaba Ankara";
	char nereye[30]="";
	
	strncopy(nereye,nereden,9); //nereden değikenindeki cümlenin 9 karakterini nereye değişkenine aktar
	printf("%s",nereye);
	//Output = Merhaba A
	
	
	
	
	return 0;
}
```

# 40- Strcat Fonksiyonu
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//strcat = Metin ifadelerini birleştirmek için kullanılır
	char kitapad[30],yazar[30],kitapyazar[60];
	
	printf("Kitap adi ve Yazari girin: ");
	scanf("%s%s",kitapad,yazar);
	
	strcat(kitapyazar,kitapad);
	strcat(kitapyazar," ");
	strcat(kitapyazar,"<---> ");
	strcat(kitapyazar,yazar);
	printf("\n\n");
	printf("%s",kitapyazar);
	
	
	
	return 0;
}
```

# 41- Enum Yapısı
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

//Ellerin plaka numaralarını öğrenmek istersek 81 tane if-else kullanmamız gerekir
//Bunun yerine enum kullanarak daha pratik ve kısa yollu bir çözüm elde edebiliriz

enum sehirler{
	ilkdeger,adana,adiyaman,afyon,agri,amasya,ankara,antalya,balikesir
};


int main() {
	
	enum sehirler il;
	il=amasya;
	printf("%d",il); //%d kullanılıyor çünkü il değişkenin değeri otomatik olarak bir indeks numarası vermektedir
	//Output = 5
	
	
	return 0;
}
```

# 42- Struct 1
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

struct kitapbilgi{
	char kitapad[20];
	char yazar[20];
	int fiyat;
	float puan;
};


int main(int argc, char *argv[]) {
	
	
	struct kitapbilgi kb={
		"SekerPortakali",
		"Vasconceulos",
		60,
		7.25
	};
	
	printf("Kitap Ad: %s\n",kb.kitapad);
	printf("Yazar: %s\n",kb.yazar);
	printf("Fiyat: %d TL\n",kb.fiyat);
	printf("Puan: %.2f",kb.puan);
	
	
	return 0;
}
```

# 43- Struct 2
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

struct kayit{
	char ad[20];
	int no;
	int sinif;
	float ort;
};
struct kayit ogr;

int main() {
	
	
	printf("Ogrenci Adi: ");
	scanf("%s",&ogr.ad);
	printf("Numara: ");
	scanf("%d",&ogr.no);
	printf("Sinif: ");
	scanf("%d",&ogr.sinif);
	printf("Ortalama: ");
	scanf("%f",&ogr.ort);
	
	printf("\n%s\n",ogr.ad);
	printf("%d\n",ogr.no);
	printf("%d\n",ogr.sinif);
	printf("%.2f\n",ogr.ort);
	
	
	return 0;
}
```

# 44- Typedef Kullanımı
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */


typedef int tamsayi;

typedef int deger;

int main() {
	
	
	//C# dilindeki class çağırıp kullanmaya benziyor
	tamsayi ts,ts2,ts3;
	ts=22;
	ts2=23;
	ts3=26;
	printf("%d %d %d",ts,ts2,ts3);	
	
	
	
	deger d1,d2;
	int toplam;
	
	d1=20;
	d2=40;
	
	toplam=d1+d2;
	
	printf("\n\nToplam Deger: %d",toplam);
	
	
	
	
	return 0;
}
```

# 45- Pointer 1
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Pointer bizlere değişken değerlerimizin RAM bellekte hangi kod ile tutulduğunu gösterir
	//Türkçe anlamı işaretçi demektir
	//Bellekte tutulan kodlar Hexedecimal olarak tutulur (16'lık sayı birimi)
	
	int sayi1=10;
	int sayi2=20;
	double sayi3=10.25;
	char kelime='a';
	
	printf("%d\n",sayi1);
	printf("%d\n",sayi2);
	printf("%f\n",sayi3);
	printf("%c\n",kelime);
	
	printf("\n\n--- Bellek Adresleri --- \n\n");
	
	printf("%x\n",&sayi1);
	printf("%x\n",&sayi2);
	printf("%x\n",&sayi3);
	printf("%x\n",&kelime);
	
	
	//Programı birkaç saat sonra tekrar çalıştırdığımızda bellek adres kodları değişebilir
	//Her bilgisayarda bellek adres kodları değişkenlik gösterebilir	
	
	
	return 0;
}
```

# 46- Pointer 2
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Bellek adres kodlarını değişkenlerde tutabiliriz
	int sayi=10;
	int *s=&sayi;
	
	//Sayıyı ekrana yazdırma
	printf("Deger: %d\n",sayi);
	
	//Adresi ekrana yazdırma
	printf("Adres: %x\n",s);
	
	printf("\n--------------\n\n");
	
	char harf='a';
	char *h=&harf;
	
	//Harfi ekrana yazdırma
	printf("Deger: %c\n",harf);
	
	//Adresi ekrana yazdırma
	printf("Adres: %x\n",h);
	
	
	
	
	return 0;
}
```

# 47- Pointer 3
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	//Adres kodlarında arttırma ve azaltma gibi matematiksel işlemler uygulanabilir
	
	char harf='k';
	char *pt=&harf;
	
	printf("Adres: %x\n",pt); //62fe17
	pt++;
	printf("Adres: %x\n",pt); //62fe18
	pt--;
	printf("Adres: %x\n",pt); //62fe17
	
	pt=pt+7;
	printf("Adres: %x\n",pt); //62fe1e
	//Hexedecimal kodlarda 9'dan sonra a-b-c-d-e-f gelir
	
	
	return 0;
}
```

# 48- Fonksiyonlar 1
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

//Geriye değer döndürmeyen fonksiyonlar için void kullanılır
//Void boş demektir
void listele(){
	printf("Berkan Nihat Yıldız\n");
	printf("Ecmel Yıldız\n");
	printf("Ecrin Yıldız\n");
	printf("Mert Yıldız\n");
	printf("Tunahan Yıldız\n");
}



int main() {
	
	
	//Şimdi fonksiyonumuzu çağırıyoruz
	listele();
	
	
	return 0;
}
```

# 49- Fonksiyonlar 2
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

//Geriye değer göndüren fonksiyonlar
int toplam(int s1,int s2){
	int s3;
	s3=(s1+s2)*5-10;
	return s3;
}


int main() {
	
	
	int t;
	t=toplam(4,5);
	printf("%d\n",t); //35
	
	
	printf("%d",toplam(2,3)); //15
	
	
	
	
	return 0;
}
```

# 50- Fonksiyonlar 3
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */


//Girilen sayının kübünü bulan fonksiyon
int kupbul(int sayi){
	
	int sonuc=sayi*sayi*sayi;
	return sonuc;
}


//Kısa ve uzun kenar uzunlukları girilen dikdörtgeni çizdiren fonksiyon
void dortgen(int kisa,int uzun){
	
	int i,j;
	for(i=0;i<uzun;i++){
		for(j=0;j<kisa;j++){
			printf("*");
		}
		printf("\n");
	}
}



int main() {
	
	
	int s;
	printf("Sayiyi girin: ");
	scanf("%d",&s);
	
	printf("\nSonuc: %d\n\n",kupbul(s));
	
	
	
	dortgen(7,18);
	
	
	
	return 0;
}
```

# 51- Proje Örneği (Matematik Menüsü)
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	printf("********************");
	printf("\n");
	printf("**      MENU      **");
	printf("\n");
	printf("********************");
	printf("\n\n");
	
	printf("1.Toplama islemi\n");
	printf("2.Carpma islemi\n");
	printf("3.Kare bul\n");
	printf("4.Kup bul\n");
	printf("5.Denklem (5x^2+4x+3)");
	
	int secim,s1,s2,sonuc;
	printf("\n\nisleminiz: ");
	scanf("%d",&secim);
	switch(secim){
		case 1:
			printf("iki sayi girin: ");
			scanf("%d%d",&s1,&s2);
			sonuc=s1+s2;
			printf("Toplam: %d",sonuc);
			break;
		case 2:
			printf("iki sayi girin: ");
			scanf("%d%d",&s1,&s2);
			sonuc=s1*s2;
			printf("Carpim: %d",sonuc);
			break;
		case 3:
			printf("Karesi alinacak sayi: ");
			scanf("%d",&s1);
			sonuc=s1*s1;
			printf("Kare Sonuc: %d",&sonuc);
			break;
		case 4:
			printf("Karesi alinacak sayi: ");
			scanf("%d",&s1);
			sonuc=s1*s1*s1;
			printf("Kup Sonuc: %d",&sonuc);
			break;
		case 5:
			printf("X degerini girin: ");
			scanf("%d",&s1);
			sonuc=5*s1*s1+4*s1+3;
			printf("Denklem Sonucu: %d",sonuc);
			break;
			
			
	}
	
	
	
	
	
	
	
	return 0;
}
```

# 52- Önişlemci Komutları (Define Kullanımı)
```c
#include <stdio.h>
#include <stdlib.h>

#define tPuan 2.19
#define mPuan 3.47

/* run this program using the console pauser or add your own getch, system("pause") or input loop */



int main() {
	
	
	int turkce,matematik;
	printf("Turkce netinizi giriniz: ");
	scanf("%d",&turkce);
	printf("Matematik netinizi giriniz: ");
	scanf("%d",&matematik);

	
	float sozelPuan,sayisalPuan;
	sozelPuan=turkce*tPuan+matematik*mPuan+50.25;
	sayisalPuan=turkce*tPuan+matematik*mPuan+51.45;
	
	printf("Toplam Sozel Puaniniz: %.2f\n",sozelPuan);
	printf("Toplam Sayisal Puaniniz: %.2f",sayisalPuan);
		
	
	
	return 0;
}
```

# 53- Makro Kullanımı
```c
#include <stdio.h>
#include <stdlib.h>

//Define ile if-else kısa kullanımı -makro-
#define Maksimum(s1,s2) (s1>s2) ? s1 : s2

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	printf("%d\n",Maksimum(5,8)); //8
	printf("%d\n",Maksimum(7,3)); //7
	printf("%d\n",Maksimum(4,4)); //4	
	
	
	
	return 0;
}
```

# 54- Dosya İşlemleri 1 (Metin Belgesi Oluşturma)
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	FILE *dosya;
	dosya=fopen("C:\\Users\\nihat\\OneDrive\\Belgeler\\GitHub\\Learning-Programming-Languages\\C\\54-Dosya_Islemleri_1_Metin_Belgesi_Olusturma\\deneme.txt","w");
	//deneme.txt isimli boş bir dosya oluşturduk	
	
	
	return 0;
}
```

# 55- Dosya İşlemleri 2 (Metin Belgesine Veri Yazma)
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	FILE *dosya;
	dosya=fopen("C:\\Users\\nihat\\OneDrive\\Belgeler\\GitHub\\Learning-Programming-Languages\\C\\55-Dosya_Islemleri_2_Metin_Belgesine_Veri_Yazma\\bilgi.txt","w");
	
	
	putc('a',dosya);
	putc('\n',dosya);
	putc('b',dosya);
	
		
	fclose(dosya);
	
	
	return 0;
}
```

# 56- Dosya İşlemleri 3 (Metin Belgesi Okuma)
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	FILE *belge;
	char karakter;
	belge=fopen("C:\\Users\\nihat\\OneDrive\\Belgeler\\GitHub\\Learning-Programming-Languages\\C\\56-Dosya_Islemler_3_Metin_Belgesi_Okuma\\bilgi.txt","r");
	
	//Metin belgesinin içerisindeki yazımız:
	//Merhaba, deprem bolgesinden herkese selamlar.
	karakter=getc(belge);
	
	printf("%c",karakter);
	//Bu şekilde yaparsak bize yalnızca ilk karakteri, yani M harfini getirir
	
	do{
		karakter=getc(belge);
		
		printf("%c",karakter);
	}
	while(karakter!=EOF); //EOF = End Of File (Dosyanın sonu)
	//Bu döngünün sonuucnda ekranda, belgenin içerisindeki bütün yazılar görüntülenecektir
	
	fclose(belge);
	
	
	
	return 0;
}
```

# 57- Dosya İşlemleri 4 (fgets Kullanımı)
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	
	FILE *belge;
	char karakter[50];
	belge=fopen("C:\\Users\\nihat\\OneDrive\\Belgeler\\GitHub\\Learning-Programming-Languages\\C\\57-Dosya_Islemleri_4_fgets_Kullanimi\\bilgi.txt","r");
	//Belgemizde yazanlar:
	//6 Subat depremini unutmayacagız, unutturmayacagız.
	
	
	fgets(karakter,15,belge); //belgeden 15 karakteri al ve karakter değişkenine aktar
	puts(karakter); //karakter değişkenini ekranda görüntüle
	//6 Subat deprem
	
	
	fclose(belge);
	
	
	
	return 0;
}
```

# 58- Dosya İşlemleri 5 (fputs Kullanımı)
```c
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
```

# 59- Yazı Rengini Değiştirme
```c
#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	
	printf("On binlerce insanimizin vefat ettigi 6 subat depreminin hesabi sorulacak.");
	system("COLOR 0");
	system("COLOR 1");
	system("COLOR 2");
	system("COLOR 3");
	system("COLOR 4");
	system("COLOR 5");
	system("COLOR 6");
	system("COLOR 7");
	system("COLOR 8");
	system("COLOR 9");
	system("COLOR A");
	system("COLOR B");
	system("COLOR C");
	system("COLOR D");
	system("COLOR E");
	system("COLOR F");
	
	
	return 0;
}
```
