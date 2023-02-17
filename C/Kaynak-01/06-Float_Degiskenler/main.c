#include <stdio.h>
#include <stdlib.h>
#include <locale.h> // Türkçe karakter uyumluluðu için kütüphanemizi entegre ediyoruz

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	setlocale(LC_ALL,"turkish"); // Entegre ettiðimiz kütüphanemizi Türkçe dili olarak ayarlýyoruz
	
	
	/*
	float s1,s2,s3,ort;
	s1=75;
	s2=80;
	s3=81;
	
	ort=(s1+s2+s3)/3;
	printf("Ortalama: %f",ort); // Float türündeki deðiþkenler için %f kullanýlýr
	*/
	
	
	
	
	
	// Ýdeal kilo hesaplama
	printf("Ýdeal Kilo Hesaplama");
	printf("\n");
	
	float boy, yas, ideal;
	boy=165;
	yas=24;
	ideal=(boy-100+yas/10)*0.9;
	
	printf("Ýdeal kilonuz: %f",ideal);
	
	
	
	
	
	return 0;
}
