#include <stdio.h>
#include <stdlib.h>
#include <locale.h> // T�rk�e karakter uyumlulu�u i�in k�t�phanemizi entegre ediyoruz

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
	
	setlocale(LC_ALL,"turkish"); // Entegre etti�imiz k�t�phanemizi T�rk�e dili olarak ayarl�yoruz
	
	
	/*
	float s1,s2,s3,ort;
	s1=75;
	s2=80;
	s3=81;
	
	ort=(s1+s2+s3)/3;
	printf("Ortalama: %f",ort); // Float t�r�ndeki de�i�kenler i�in %f kullan�l�r
	*/
	
	
	
	
	
	// �deal kilo hesaplama
	printf("�deal Kilo Hesaplama");
	printf("\n");
	
	float boy, yas, ideal;
	boy=165;
	yas=24;
	ideal=(boy-100+yas/10)*0.9;
	
	printf("�deal kilonuz: %f",ideal);
	
	
	
	
	
	return 0;
}
